﻿using System;
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
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddServer verifyservers = new AddServer();
            verifyservers.Show();
           String s =  ((TextBox)verifyservers.Controls["textBox1"]).Text;
            MessageBox.Show(s);

        }
    }
}
