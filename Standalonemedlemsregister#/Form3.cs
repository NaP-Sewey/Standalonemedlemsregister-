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
                if (s.Length >= 5)
                {
                    string brugernavn = s[0];
                    string navn = s[2];
                    string mail = s[3];
                    string status = s[4];

                    listBox1.Items.Add($"Brugernavn: {brugernavn}, Navn: {navn}, Status: {status}");
                }
            }
        }
    }
}
