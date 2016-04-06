using System;
using System.Windows.Forms;

public partial class NewItem : Form
{
    public int quant, table;
    public Boolean type;
    public string desc;
    private string type_ = null;

    public NewItem()
    {
        InitializeComponent();
    }

    private void okButton_Click(object sender, EventArgs e)
    {
        if (type_ == null)
        {
            MessageBox.Show("Destination needs Value!", "Invalid data", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        else
        {
            quant = Convert.ToInt32(numericUpDown1.Value);
            table = Convert.ToInt32(numericUpDown2.Value);
            type = type_.Equals("Bar") ? true : false;
            desc = description.Text;
        }

    }

    private void destination_SelectedIndexChanged(object sender, EventArgs e)
    {
        type_ = destination.Items[destination.SelectedIndex].ToString();
    }
}
