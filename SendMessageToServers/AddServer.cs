using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.DirectoryServices;
using System.DirectoryServices.ActiveDirectory;
using System.Windows.Forms;

namespace SendMessageToServers
{
    
    public partial class AddServer : Form
    {
        public string Str = null;
        public AddServer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i;
            String[] servers = textBox1.Text.Split(';');
            for(i = 0; i < servers.Length; i++)
            {
                string sADPath = "LDAP://nwtraders.com";
                DirectoryEntry de = new DirectoryEntry(sADPath);

                string sFilter = "(&(objectCategory=computer)(name=" + servers[i] + "))";
                DirectorySearcher DirectorySearch = new DirectorySearcher(de, sFilter);
                SearchResult DirectorySearchResult = DirectorySearch.FindOne();
                
                   

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Str = textBox1.Text;
            this.Close();
        }

        private void AddServer_Load(object sender, EventArgs e)
        {

        }
    }
}
