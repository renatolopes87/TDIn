using System;
using System.Collections;
using System.Runtime.Remoting;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

public partial class Bill : Form
{
    

    private void closeTable_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    public Bill(Dictionary<String,int> bill, Dictionary<String,double> menu, int t, double price)
    {
        InitializeComponent();
        foreach (string d in bill.Keys)
        {
            ListViewItem lvItem = new ListViewItem(new string[] { d, bill[d].ToString(), menu[d].ToString() + " €", (bill[d] * menu[d]).ToString() + " €" });
            itemListView2.Items.Add(lvItem);
        }

        ListViewItem lvItem2 = new ListViewItem(new string[] { "", "", "", "" });
        itemListView2.Items.Add(lvItem2);
        ListViewItem lvItemTotal = new ListViewItem(new string[] { "TOTAL", "", "", price.ToString() + " €"});
        itemListView2.Items.Add(lvItemTotal);
    }

    private void itemListView2_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}