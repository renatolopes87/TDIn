using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


    public partial class SearchByTable : Form
    {
        public SearchByTable(int val)
        {
        
            InitializeComponent();
        this.Text = this.Text+":" + val;
    }


        private void button_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
