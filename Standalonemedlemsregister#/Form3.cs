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

                if (s.Length >= 6) 
                {
                    string brugernavn = s[0];
                    string mail = s[2];
                    string navn = s[3];
                    string phonenumber = s[4];
                    string status = s[5];

                    listBox1.Items.Add($"Brugernavn: {brugernavn}, Mail: {mail}, Navn: {navn}, Tlf.nr: {phonenumber}, Status: {status}");
                    
                }
            }
        }
    }
}
