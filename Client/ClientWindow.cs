using System;
using System.Collections;
using System.Runtime.Remoting;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

public partial class ClientWindow : Form
{
    IListSingleton listServer;
    AlterEventRepeater evRepeater;
    AlterEventRepeaterID evRepeaterID;
    AlterEventRepeaterTable evRepeaterTable;
    ArrayList items;
    ArrayList tables;
    Dictionary<string, double> menuList;
    Item itemToChange;
    delegate ListViewItem LVAddDelegate(ListViewItem lvItem);
    delegate void ChStateDelegate(Item item);
    delegate void ClearDelegate();


    //public delegate void CleanListViewItem();

    public ClientWindow()
    {
        RemotingConfiguration.Configure("Client.exe.config", false);
        InitializeComponent();
        listServer = (IListSingleton)RemoteNew.New(typeof(IListSingleton));
        items = listServer.GetList();
        addAllItems();
        tables = listServer.GetTables();
        tableSelector.DataSource = tables;
        menuList = new Dictionary<string, double>();
       
        menuList.Add("A01. Arroz ao Forno", 4.2);
        menuList.Add("A02. Pimentões assados recheados com Bacalhau", 2);
        menuList.Add("A03. Arroz de bacalhau no forno", 2.2);
        menuList.Add("A04. Macarrão no forno", 2.4);
        menuList.Add("A05. Bolo bem casado com recheio de nozes", 2.7);
        menuList.Add("A06. Feijoada de frango", 2.4);
        menuList.Add("A07. Bacalhau de festa", 3.1);
        menuList.Add("A08. Bolo pudim de doce de leite", 2.1);
        menuList.Add("A09. Arroz de Lula", 2);

        menuList.Add("M01. Caneloni recheado com cogumelos", 2.4);
        menuList.Add("M02. Bife de chourizo grelhado com manteiga de ervas", 2.7);
        menuList.Add("M03. Feijão-tropeiro", 2.4);
        menuList.Add("M04. Virado à paulista", 3.1);
        menuList.Add("M05. Bolo bem casado com recheio de nozes", 2.1);
        menuList.Add("M06. Lamen chinês", 2);

        menuList.Add("PA01. Fino", 0.8);
        menuList.Add("PA02. Tosta Mista", 2.7);
        menuList.Add("PA03. Pizza ", 2.4);

        evRepeater = new AlterEventRepeater();
        evRepeaterID = new AlterEventRepeaterID();
        evRepeaterTable = new AlterEventRepeaterTable();
        evRepeater.alterEvent += new AlterDelegate(DoAlterations);
        evRepeaterTable.alterEventTable += new AlterDelegateTable(DoAlterations);
        evRepeaterID.alterEventID += new AlterDelegateID(DoAlterationsID);
        listServer.alterEvent += new AlterDelegate(evRepeater.Repeater);
        listServer.alterEventTable += new AlterDelegateTable(evRepeaterTable.Repeater);
        listServer.alterEventID += new AlterDelegateID(evRepeaterID.Repeater);
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

    public void DoAlterations(Operation op, int table)
    {
        evRepeater = new AlterEventRepeater();
        switch (op)
        {
            case Operation.New:
                tables.Add(table);
                tables.Sort();
                break;
            case Operation.Change:
                tables.Remove(table);
                break;
        }
        tableSelector.DataSource = null;
        tableSelector.DataSource = tables;
    }

    void UpdateNew()
    {
        if (InvokeRequired)
            Invoke(new MethodInvoker(UpdateNew));
        else
        {
            ListViewItem lvItem = new ListViewItem(new string[] { itemToChange.ID.ToString(), itemToChange.Description, itemToChange.State, itemToChange.Quantity.ToString(), itemToChange.Table.ToString(), itemToChange.Type.ToString() });
            itemListView.Items.Add(lvItem);
            lvItem.BackColor =  Color.Red;//change color
            items.Add(itemToChange);
        }
        itemToChange = null;
    }

    void UpdateChange()
    {
        if (InvokeRequired)
            Invoke(new MethodInvoker(UpdateChange));
        else
        {
            for (int i = 0; i < items.Count; i++)
            {
                if (((Item)items[i]).ID == itemToChange.ID)
                {
                    itemListView.Items[i].SubItems[2].Text = itemToChange.State;
                    ((Item)items[i]).State = itemToChange.State;
                    if (itemToChange.State.Equals("Ready"))
                        itemListView.Items[i].BackColor = Color.Green;
                    if (itemToChange.State.Equals("Preparing"))
                        itemListView.Items[i].BackColor = Color.Yellow;
                    break;
                }
            }

            if (itemToChange.State.Equals("Ready")) { 
                MessageBox.Show("Request " + itemToChange.ID + " (" + itemToChange.Description + ") is ready!");

            }
        }
        itemToChange = null;
    }

    private void ClientWindow_FormClosed(object sender, FormClosedEventArgs e)
    {
        listServer.alterEvent -= new AlterDelegate(evRepeater.Repeater);
        evRepeater.alterEvent -= new AlterDelegate(DoAlterations);
    }

    private void addRequestButton_Click(object sender, EventArgs e)
    {
        Console.WriteLine("addItemButton_Click()");
        List<string> list = new List<string>(menuList.Keys);
        NewItem newIt = new NewItem(list);
        if (newIt.ShowDialog(this) == DialogResult.OK)
        {
            Item it = new Item(listServer.GetNewType(), newIt.desc, "Waiting", newIt.quant, newIt.table, menuList[newIt.desc], newIt.type);
            listServer.AddItem(it);
        }
    }

    private void closeButton_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }

    private void closeTable_Click(object sender, EventArgs e)
    {
        if (tableSelector.SelectedIndex > -1)
        {
            int t = Convert.ToInt32(tableSelector.Items[tableSelector.SelectedIndex].ToString());
            listServer.CloseTable(t);
        }
    }

    private void price_Click(object sender, EventArgs e)
    {
        if (tableSelector.SelectedIndex > -1)
        {
            int t = Convert.ToInt32(tableSelector.Items[tableSelector.SelectedIndex].ToString());
            Dictionary<string, int> bill = new Dictionary<string, int>();
            double price = 0.0;
            foreach (Item i in items)
                if (i.Table == t)
                {
                    if (!bill.ContainsKey(i.Description))
                        bill.Add(i.Description, i.Quantity);
                    else
                        bill[i.Description] += i.Quantity;

                    price += i.Quantity * i.Price;
                }
            Bill b = new Bill(bill, menuList, t, price);
            b.Show();

        }
    }

    private void checkBox1_CheckedChanged(object sender, EventArgs e)
    {

        if (tableSelector.SelectedIndex > -1)
        {
            itemListView.Items.Clear();
            if (checkBox1.Checked)
            {
                int t = Convert.ToInt32(tableSelector.Items[tableSelector.SelectedIndex].ToString());
                addAllItems(t);
            }
            else
                addAllItems();
        }
    }

    private void addAllItems(int t)
    {
        foreach (Item it in items)
            if (it.Table == t)
            {
                ListViewItem lvItem = new ListViewItem(new string[] { it.ID.ToString(), it.Description, it.State, it.Quantity.ToString(), it.Table.ToString(), it.Type.ToString() });
                itemListView.Items.Add(lvItem);
            }
    }

    private void addAllItems()
    {
        foreach (Item it in items)
        {
            ListViewItem lvItem = new ListViewItem(new string[] { it.ID.ToString(), it.Description, it.State, it.Quantity.ToString(), it.Table.ToString(), it.Type.ToString() });
            itemListView.Items.Add(lvItem);
        }
    }

    private void tableSelector_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (tableSelector.SelectedIndex > -1)
        {
            if (checkBox1.Checked)
            {
                itemListView.Items.Clear();
                int t = Convert.ToInt32(tableSelector.Items[tableSelector.SelectedIndex].ToString());
                addAllItems(t);
            }
        }
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