using System;
using System.Collections;
using System.Runtime.Remoting;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

public partial class InternalClientWindow : Form
{
    IListSingleton listServer;
    AlterEventRepeater evRepeater;
    AlterEventRepeaterID evRepeaterID;
    ArrayList items;
    int ClientID;
    string InternalType;
    Item itemToChange;
    delegate ListViewItem LVAddDelegate(ListViewItem lvItem);
    delegate void ChStateDelegate(Item item);

    public InternalClientWindow(string type)
    {
        this.InternalType = type;
        RemotingConfiguration.Configure("InternalClient.exe.config", false);
        listServer = (IListSingleton)RemoteNew.New(typeof(IListSingleton));
        items = listServer.GetInternalList(InternalType);
        for (int i = items.Count - 1; i >= 0; i--)
            if (((Item)items[i]).State.Equals("Ready"))
                items.RemoveAt(i);
        evRepeater = new AlterEventRepeater();
        evRepeater.alterEvent += new AlterDelegate(DoAlterations);
        listServer.alterEvent += new AlterDelegate(evRepeater.Repeater);
        evRepeaterID = new AlterEventRepeaterID();
        evRepeaterID.alterEventID += new AlterDelegateID(DoAlterationsID);
        listServer.alterEventID += new AlterDelegateID(evRepeaterID.Repeater);

        AppClient cli = new AppClient(listServer.GetNewTypeClient(), "kitchen");
        listServer.AddClient(cli);
        ClientID = cli.ID;
        InitializeComponent(type, ClientID);
        foreach (Item it in items)
        {
            ListViewItem lvItem = new ListViewItem(new string[] { it.ID.ToString(), it.Description, it.State, it.Table.ToString(), it.Quantity.ToString(), this.InternalType });
            itemListView.Items.Add(lvItem);
        }
        Console.WriteLine("InternalClientWindow()");
    }

    /* The client is also a remote object. The Server calls remotely the AlterEvent handler  *
     * Infinite lifetime                                                                     */

    public override object InitializeLifetimeService()
    {
        return null;
    }

    /* Event handler for the remote AlterEvent subscription and other auxiliary methods */

    public void DoAlterationsID(Operation op, ArrayList id)
    {
        for (int i = 0; i < id.Count; i++)
            for (int j = items.Count - 1; j >= 0; j--)
            {
                if (((Item)items[j]).ID == (int)id[i])
                {
                    items.RemoveAt(j);
                    itemListView.Items.RemoveAt(j);
                    itemListView.Refresh();
                    break;
                }
            }
        //MessageBox.Show(id.ToString() + " " + items.Count.ToString());
    }

    public void DoAlterations(Operation op, Item item)
    {
        itemToChange = item;
        switch (op)
        {
            case Operation.New:
                UpdateNew();
                break;
            case Operation.Change:
                UpdateChange();
                break;
        }
    }

    void UpdateNew()
    {
        if (InvokeRequired)
            Invoke(new MethodInvoker(UpdateNew));
        else
        {
            String dest;
            if (!itemToChange.Type)
                dest = "kitchen";
            else
                dest = "bar";
            if (dest == this.InternalType)
            {
                ListViewItem lvItem = new ListViewItem(new string[] { itemToChange.ID.ToString(), itemToChange.Description, itemToChange.State, itemToChange.Table.ToString(), itemToChange.Quantity.ToString(), dest });
                itemListView.Items.Add(lvItem);
                items.Add(itemToChange);
            }
        }
        itemToChange = null;
    }

    void UpdateChange()
    {
        if (InvokeRequired)
            Invoke(new MethodInvoker(UpdateChange));
        else
        {
            String dest;
            if (!itemToChange.Type)
                dest = "kitchen";
            else
                dest = "bar";
            if (dest == this.InternalType)
                for (int i = 0; i < items.Count; i++)
                    if (((Item)items[i]).ID == itemToChange.ID)
                    {
                        if (itemToChange.State.Equals("Ready"))
                            itemListView.Items.RemoveAt(i);
                        else
                        {
                            itemListView.Items[i].SubItems[2].Text = itemToChange.State;
                            ((Item)items[i]).State = itemToChange.State;
                        }
                        break;
                    }
        }
        //ClientWindow_Load(null, null);
    }

    /* Client interface event handlers */

    private void ClientWindow_FormClosed(object sender, FormClosedEventArgs e)
    {
        listServer.alterEvent -= new AlterDelegate(evRepeater.Repeater);
        evRepeater.alterEvent -= new AlterDelegate(DoAlterations);
    }

    private void changeStateButton_Click(object sender, EventArgs e)
    {
        if (itemListView.SelectedItems.Count > 0)
        {
            int id = Convert.ToInt32(itemListView.SelectedItems[0].SubItems[0].Text);
            for (int i = 0; i < items.Count; i++)
                if (((Item)items[i]).ID == id)
                    if (((Item)items[i]).State.Equals("Waiting"))
                    {
                        ((Item)items[i]).State = "Preparing";
                        listServer.ChangeState(id, "Preparing");
                    }
                    else if (((Item)items[i]).State.Equals("Preparing"))
                    {
                        listServer.ChangeState(id, "Ready");
                        items.RemoveAt(i);
                        itemListView.Items.RemoveAt(i);
                        break;
                    }
        }


    }

    private void closeButton_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }

}

/* Mechanism for instanciating a remote object through its interface, using the config file */

class RemoteNew
{
    private static Hashtable types = null;

    private static void InitTypeTable()
    {
        types = new Hashtable();
        foreach (WellKnownClientTypeEntry entry in RemotingConfiguration.GetRegisteredWellKnownClientTypes())
            types.Add(entry.ObjectType, entry);
    }

    public static object New(Type type)
    {
        if (types == null)
            InitTypeTable();
        WellKnownClientTypeEntry entry = (WellKnownClientTypeEntry)types[type];
        if (entry == null)
            throw new RemotingException("Type not found!");
        return RemotingServices.Connect(type, entry.ObjectUrl);
    }
}
