using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Standalonemedlemsregister_
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
       
         
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            string[] alleBrugere = File.ReadAllLines("Database\\Users.txt");

            foreach (string linje in alleBrugere)
            {
                string[] s = linje.Split(',');

                if (s.Length >= 4) // nu kun 4 felter
                {
                    string brugernavn = s[0];
                    string mail = s[2];
                    string status = s[3];

                    listBox1.Items.Add($"Brugernavn: {brugernavn}, Mail: {mail}, Status: {status}");
                }
            }
        }
    }
}
