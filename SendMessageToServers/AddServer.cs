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
            String Domainname = System.Net.NetworkInformation.IPGlobalProperties.GetIPGlobalProperties().DomainName;
            String[] servers = textBox1.Text.Split(';');
            textBox1.Text = null;
            bool firstelement = false;
            var myList = new List<string>();
            for (i = 0; i < servers.Length; i++)
            {
                String serverNetBiosName = null;
                string sADPath = "LDAP://" + Domainname;
                DirectoryEntry de = new DirectoryEntry(sADPath);
                if (servers[i].Contains("."))
                {
                     serverNetBiosName = servers[i].Split('.')[0];
                }
                else
                {
                    serverNetBiosName = servers[i];
                }
                string sFilter = "(&(objectCategory=computer)(name=" + serverNetBiosName + "))";
                DirectorySearcher DirectorySearch = new DirectorySearcher(de, sFilter);
                SearchResult DirectorySearchResult = DirectorySearch.FindOne();
                if (DirectorySearchResult != null)
                {
                    
                    
                    String Servername = serverNetBiosName + "." + Domainname;
                    

                    textBox1.Font = new Font("Times New Roman", 10, FontStyle.Underline);
                    if (!firstelement)
                    {
                        textBox1.Text = textBox1.Text + Servername;
                        firstelement = true;
                        myList.Add(Servername);
                        
                    }
                    else
                    {   if (!myList.Contains(Servername))
                        {
                            textBox1.Text = textBox1.Text + ";" + Servername;
                            myList.Add(Servername);
                        }   
                    }

                }




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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
