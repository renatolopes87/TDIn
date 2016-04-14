using System;
using System.Windows.Forms;
using System.Collections;
using System.Collections.Generic;

public partial class NewItem : Form
{
    public int quant, table;
    public Boolean type;
    public string desc;
    public ArrayList oktables;

    public NewItem(List<String> m,ArrayList oktables)
    {
        InitializeComponent();
        description.DataSource = m;
        this.oktables = oktables;
    }

    private void okButton_Click(object sender, EventArgs e)
    {
        quant = Convert.ToInt32(numericUpDown1.Value);
        table = Convert.ToInt32(numericUpDown2.Value);
        type = destination.SelectedIndex == 1 ? true : false;
        desc = description.Items[description.SelectedIndex].ToString();
    }

    private void numericUpDown2_ValueChanged(object sender, EventArgs e)
    {
      
        int count = Convert.ToInt32(Math.Round(numericUpDown2.Value, 0));
        if (this.oktables.Contains(count))
        {
            MessageBox.Show("This table is waiting payment");
            okButton.Enabled = false;
        }
        else
        {
            okButton.Enabled =  true;
        }
       
    }

    private void description_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (description.Items[description.SelectedIndex].ToString().Substring(0, 1).Equals("A"))
            destination.SelectedIndex = 1;
        else if (description.Items[description.SelectedIndex].ToString().Substring(0, 2).Equals("PA"))
            destination.SelectedIndex = 1;
        else
            destination.SelectedIndex = 0;

    }
}
