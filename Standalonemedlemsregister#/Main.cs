using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Standalonemedlemsregister_
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            string[] alleBrugere = File.ReadAllLines("Database\\Users.txt");

            foreach (string linje in alleBrugere)
            {
                string[] s = linje.Split(',');

                if (s.Length >= 6)
                {
                    string username = s[0];
                    string mail = s[2];
                    string navn = s[3];
                    string phonenumber = s[4];
                    string status = s[5];
                    if (username == Form1.Bruger)
                    {
                        listBox1.Items.Add($"Brugernavn: {username}, Mail: {mail}, Navn: {navn},Tlf.Nr: {phonenumber} ,  Status: {status}");
                        break;
                        
                    }
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
