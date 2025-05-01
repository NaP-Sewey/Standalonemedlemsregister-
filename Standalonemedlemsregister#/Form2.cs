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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Signup1_Click(object sender, EventArgs e)
        {
            // Herunder er de forskellige paths som definere filplaceringen hvor dataen gemmes/skal gemmes
            string path = "Database\\Cpr.txt";  //Paths
            string path2 = "Database\\Password.txt";//Paths
            string path3 = "Database\\Mail.txt";//Paths
            string path4 = "Database\\Navn.txt";//Paths
            string path5 = "Database\\tlfnum.txt";//Paths
            string path6 = "Database\\Users.txt";//Paths

            // Herunder er de forskellige data hvor der bliver hentet brugerinput fra de tekstboxe som er brugt.
            string username = textboxusername.Text; // Data
            string password = textboxpassword.Text;// Data
            string mail = MailTextbox.Text; // Data
            string navn = navnbox.Text; // Data
            string phonenumber = PhoneNumberTextbox.Text; // Data
            string confirmPassword = ConfirmPasswordTextbox.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(confirmPassword) || string.IsNullOrWhiteSpace(mail) || string.IsNullOrWhiteSpace(phonenumber))// Her bliver der tjekket om brugernavn og adgangskode er udfyldt
            {
                MessageBox.Show("ALL SPACES NEED TO BE FILLED");
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("PASSWORDS DOES NOT MATCH");
                return;
            }
;




            string[] existingUsers = File.ReadAllLines(path);
            if (existingUsers.Contains(username))
            {
                MessageBox.Show("Username is USED");
                return;

            }




            // Write data after ensuring no conflicts
            File.AppendAllText(path, username + Environment.NewLine);
            File.AppendAllText(path2, password + Environment.NewLine);
            File.AppendAllText(path3, mail + Environment.NewLine);
            File.AppendAllText(path4, navn + Environment.NewLine);
            File.AppendAllText(path5, phonenumber + Environment.NewLine);
            File.AppendAllText(path6, $"{username},{password},{mail},{navn},{phonenumber},passiv" + Environment.NewLine);












            textboxusername.Clear();
            textboxpassword.Clear();
            PhoneNumberTextbox.Clear();
            MailTextbox.Clear();
            ConfirmPasswordTextbox.Clear();

            MessageBox.Show("YOUR NOW REGISTERED", "SUCCES", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Hide();

            Form1 form1 = new Form1();
            form1.Show();






        }
        private void CreateFile(string filePath)
        {
            if (!File.Exists(filePath))
            {
                using (File.Create(filePath)) { } // Opretter filen og lukker den med det samme
            }
        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void ConfirmPasswordTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void MailTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PhoneNumberTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textboxusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void textboxpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Password1_Click(object sender, EventArgs e)
        {

        }
    }
}


        


