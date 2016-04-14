using System;
using System.Collections;

public class ListSingleton : MarshalByRefObject, IListSingleton
{
    ArrayList itemsList;
    ArrayList clientsList;
    ArrayList tablesList;
    public event AlterDelegateTable alterEventTable;
    public event AlterDelegate alterEvent;
    public event AlterDelegateID alterEventID;
    public event AlterDelegateClient alterEventClient;
    int id;
    int client = 1;
    System.IO.StreamWriter file;

    public ListSingleton()
    {
        clientsList = new ArrayList();
        itemsList = new ArrayList();
        tablesList = new ArrayList();
        Console.WriteLine("Constructor called.");
        file = new System.IO.StreamWriter(@"logfile.txt");
        file.WriteLine("Logfile started at " +  DateTime.Now);
        file.Flush();
        this.id = itemsList.Count + 1;
    }

    public override object InitializeLifetimeService()
    {
        return null;
    }

    public ArrayList GetList()
    {
        Console.WriteLine("GetList() called.");
        return itemsList;
    }

    public ArrayList GetInternalList(string t)
    {
        Boolean flag = false;
        if (t == "bar")
            flag = true;

        Console.WriteLine("GetInternalList() called.");
        ArrayList items = new ArrayList();
        foreach (Item it in itemsList)
            if (!it.State.Equals("Ready") && it.Type == flag)
                items.Add(it);
        return items;
    }

    public ArrayList GetClientsList()
    {
        Console.WriteLine("GetClientsList() called.");
        return clientsList;
    }

    public ArrayList GetTables()
    {
        Console.WriteLine("GetTablesList() called.");
        return tablesList;
    }

    public int GetNewType()
    {
        return id++;
    }

    public int GetNewTypeClient()
    {
        return client++;
    }

    public void AddItem(Item item)
    {
        if (!itemsList.Contains(item))
            itemsList.Add(item);
        if (!tablesList.Contains(item.Table))
        {
            tablesList.Add(item.Table);
            tablesList.Sort();
            NotifyClientsTable(Operation.New, item.Table);
            file.WriteLine("Table inserted in the system: " + item.Table);
        }
        NotifyClientsItem(Operation.New, item);
        file.WriteLine("New request inserted in the system: " + item.ID + " - " + item.Quantity + " x " + item.Description + 
            " on table " + item.Table);
        file.Flush();
    }

    private void NotifyClientsTable(Operation op, int t)
    {
        if (alterEventTable != null)
        {
            Delegate[] invkList = alterEventTable.GetInvocationList();

            foreach (AlterDelegateTable handler in invkList)
            {
                try
                {
                    IAsyncResult ar = handler.BeginInvoke(op, t, null, null);
                    Console.WriteLine("Invoking tables event handler");
                }
                catch (Exception)
                {
                    alterEventTable -= handler;
                }
            }
        }
    }

    public void CloseTable(int t)
    {
        ArrayList delete = new ArrayList();
        for (int i = itemsList.Count - 1; i >= 0; i--)
        {
            Item it = (Item)itemsList[i];
            
            if (it.Table == t)
            {
                delete.Add(it.ID);
                itemsList.RemoveAt(i);
                file.WriteLine("Request removed from the system: " + it.ID + " - " + it.Quantity + " x " + it.Description +
            " on table " + it.Table);
               
            }
            it = null;
        }
        NotifyClientsItem(Operation.Delete, delete);
        tablesList.Remove(t);
        NotifyClientsTable(Operation.Change, t);       
        file.WriteLine("Table removed from the system: " + t);
        file.Flush();
    }

    public void AddClient(AppClient cli)
    {
        clientsList.Add(cli);
        NotifyClientsUser(Operation.New, cli);
        file.WriteLine("New InternalClient added: " + cli.ID + " -> " + cli.Type);
        file.Flush();
    }

    public void ChangeState(int type, string st)
    {
        Item nitem = null;

        foreach (Item it in itemsList)
        {
            if (it.ID == type)
            {
                file.WriteLine("Request number " + it.ID + " changed its state from " + it.State + " to " + st);
                file.Flush();
                it.State = st;
                nitem = it;               
                break;
            }
        }
        NotifyClientsItem(Operation.Change, nitem);
        
    }

    public void ChangePaid(int type, Boolean pd)
    {
        Item nitem = null;

        foreach (Item it in itemsList)
        {
            if (it.ID == type)
            {
                file.WriteLine("Request number " + it.ID + " changed its paid from " + it.Paid + " to " + pd);
                file.Flush();
                it.Paid = pd;
                nitem = it;
                break;
            }
        }
        NotifyClientsItem(Operation.Change, nitem);

    }

    void NotifyClientsItem(Operation op, Item item)
    {
        if (alterEvent != null)
        {
            Delegate[] invkList = alterEvent.GetInvocationList();

            foreach (AlterDelegate handler in invkList)
            {
                try
                {
                    IAsyncResult ar = handler.BeginInvoke(op, item, null, null);
                    Console.WriteLine("Invoking event handler");
                }
                catch (Exception)
                {
                    alterEvent -= handler;
                }
            }
        }
    }

    void NotifyClientsItem(Operation op, ArrayList id)
    {
        if (alterEventID != null)
        {
            Delegate[] invkList = alterEventID.GetInvocationList();

            foreach (AlterDelegateID handler in invkList)
            {
                try
                {
                    IAsyncResult ar = handler.BeginInvoke(op, id, null, null);
                    Console.WriteLine("Invoking event handler");
                }
                catch (Exception)
                {
                    alterEventID -= handler;
                }
            }
        }
    }

    void NotifyClientsUser(Operation op, AppClient cli)
    {
        if (alterEventClient != null)
        {
            Delegate[] invkList = alterEventClient.GetInvocationList();

            foreach (AlterDelegateClient handler in invkList)
            {
                try
                {
                    IAsyncResult ar = handler.BeginInvoke(op, cli, null, null);
                    Console.WriteLine("Invoking event handler");
                }
                catch (Exception)
                {
                    alterEventClient -= handler;
                }
            }
        }
    }
}