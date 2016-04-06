using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace InternalClient
{
    public partial class InitialForm : Form
    {
        public string type;
        public Boolean locked;

        public InitialForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
                this.type = "kitchen";

                this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.type = "bar";
            this.Close();
        }
    }
}
