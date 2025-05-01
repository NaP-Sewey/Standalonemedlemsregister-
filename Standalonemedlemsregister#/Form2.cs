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

            // Herunder er de forskellige data hvor der bliver hentet brugerinput fra de tekstboxe som er brugt.
            string username = textboxusername.Text; // Data
            string password = textboxpassword.Text;// Data
            string mail = MailTextbox.Text; // Data
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

            if (!File.Exists(username)) using (StreamWriter sw = File.CreateText(username))

                {

                    sw.WriteLine("Username existere ikke!");


                    sw.Close();

                }

            if (!File.Exists(password)) using (StreamWriter sw = File.CreateText(password))

                {

                    sw.WriteLine("Password existere ikke!");


                    sw.Close();

                }
;
            if (!File.Exists(mail)) using (StreamWriter sw = File.CreateText(mail))

                {

                    sw.WriteLine("Mail existere ikke!");


                    sw.Close();

                }
;
            if (!File.Exists(phonenumber)) using (StreamWriter sw = File.CreateText(phonenumber))

                {

                    sw.WriteLine("Phonenumber existere ikke!");


                    sw.Close();

                }
;




            using (StreamReader sr = File.OpenText(path))
            {
                using (StreamWriter sw = File.CreateText(path2))
                {
                    string line;

                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] substring = line.Split(',');

                        string[] existingUsers = File.ReadAllLines(path);
                        if (Array.Exists(existingUsers, user => user == username))
                        {
                            MessageBox.Show("Username is USED");
                            return;
                        }
                    }

                    sw.Close();

                }



            }

            CreateFile(path);
            CreateFile(path2);
            CreateFile(path3);
            CreateFile(path4);

            // Putter username ind i username.txt, Password ind i Password.txt, mail ind i mail.txt og Phonenumber ind i phonenumber.txt
            File.AppendAllText(path, username + Environment.NewLine);
            File.AppendAllText(path2, password + Environment.NewLine);
            File.AppendAllText(path3, mail + Environment.NewLine);
            File.AppendAllText(path5, phonenumber + Environment.NewLine);

            textboxusername.Clear();
            textboxpassword.Clear();
            PhoneNumberTextbox.Clear();
            MailTextbox.Clear();
            ConfirmPasswordTextbox.Clear();

            MessageBox.Show("YOUR NOW REGISTERED", "SUCCES", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Hide();

            Form3 form3 = new Form3();
            form3.Show();






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
    }
}


        


