using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;

using System.Windows.Forms;

namespace SendMessageToServers
{
    public partial class Form1 : Form
    {
        AddServer verifyservers = new AddServer();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            verifyservers.Show();
           


        }

        private void button2_Click(object sender, EventArgs e)
        {

          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ServerList.Text = null;
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            if (verifyservers.Str != null)
            {
                MessageBox.Show("Active");
            }
        }
    }
}
