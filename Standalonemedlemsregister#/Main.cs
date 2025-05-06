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
                    if (username == Form1.Bruger) // Den her tjekker om brugernavnet i linjen er det samme som det brugernavn der er logget ind med
                    {
                        listBox1.Items.Add($"Brugernavn: {username}");
                        listBox1.Items.Add("");
                        listBox1.Items.Add($"Mail: {mail}");
                        listBox1.Items.Add("");
                        listBox1.Items.Add($"Navn: {navn}");
                        listBox1.Items.Add("");
                        listBox1.Items.Add($"Tlf.Nr: {phonenumber}");
                        listBox1.Items.Add("");
                        listBox1.Items.Add($"Status: {status}");
                        

                        break;

                    }
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
