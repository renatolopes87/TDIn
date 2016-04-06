using System;
using System.Collections;

[Serializable]
public class Item {
  public int ID, Quantity, Table;
  public double Price;
  public Boolean Type;          //0 = kitchen, 1= bar
  public string Description {get; set;}
  public string State {get; set;}

  public Item() : this(0, "default", "default", 0, 0, 0, false) {
  }

  public Item(int id, string desc, string st, int qt, int tab, double p,  Boolean itype) {
    ID = id;
    Description = desc;
    State = st;
    Quantity = qt;
    Table = tab;
    Type = itype;
    Price = p;
  }

}

[Serializable]
public class AppClient
{
    public int ID;
    public string Type;

    public AppClient(int i, string t)
    {
        this.ID = i;
        this.Type = t;
    }

}

public enum Operation { New, Change, Delete };

public delegate void AlterDelegate(Operation op, Item item);

public delegate void AlterDelegateID(Operation op, ArrayList id);

public delegate void AlterDelegateClient(Operation op, AppClient cli);

public delegate void AlterDelegateTable(Operation op, int table);

public interface IListSingleton {
  event AlterDelegate alterEvent;
  event AlterDelegateID alterEventID;
  event AlterDelegateTable alterEventTable;
  ArrayList GetList();
  ArrayList GetInternalList(string t);
  ArrayList GetClientsList();
  ArrayList GetTables();
  int GetNewType();
  int GetNewTypeClient();
  void AddItem(Item item);
  void AddClient(AppClient cli);
  void ChangeState(int type, string comment);
  void CloseTable(int p);
}

public class AlterEventRepeater : MarshalByRefObject
{
    public event AlterDelegate alterEvent;

    public override object InitializeLifetimeService()
    {
        return null;
    }

    public void Repeater(Operation op, Item it)
    {
        if (alterEvent != null)
            alterEvent(op, it);
    }
}

public class AlterEventRepeaterID : MarshalByRefObject
{
    public event AlterDelegateID alterEventID;

    public override object InitializeLifetimeService()
    {
        return null;
    }

    public void Repeater(Operation op, ArrayList id)
    {
        if (alterEventID != null)
            alterEventID(op, id);
    }
}

public class AlterEventRepeaterClient : MarshalByRefObject
{
    public event AlterDelegateClient alterEventClient;

    public override object InitializeLifetimeService()
    {
        return null;
    }

    public void Repeater(Operation op, AppClient cli)
    {
        if (alterEventClient != null)
            alterEventClient(op, cli);
    }
}

public class AlterEventRepeaterTable : MarshalByRefObject
{
    public event AlterDelegateTable alterEventTable;

    public override object InitializeLifetimeService()
    {
        return null;
    }

    public void Repeater(Operation op, int t)
    {
        if (alterEventTable != null)
            alterEventTable(op, t);
    }
}


