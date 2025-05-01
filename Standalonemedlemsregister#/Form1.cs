namespace Standalonemedlemsregister_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login1_Click(object sender, EventArgs e)
        {
            // Herunder er de forskellige paths som definere filplaceringen hvor dataen gemmes/skal gemmes
            string path = "Database\\Cpr.txt";  //Paths
            string path2 = "Database\\Password.txt";//Paths
            string path3 = "Database\\Mail.txt";//Paths
            string path4 = "Database\\Navn.txt";//Paths

            // Herunder er de forskellige data hvor der bliver hentet brugerinput fra de tekstboxe som er brugt.
            string username = textboxusername.Text; // Data
            string password = textboxpassword.Text;// Data

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password)) // Her bliver der tjekket om brugernavn og adgangskode er udfyldt
            {
                MessageBox.Show("ALL SPACES NEED TO BE FILLED");
                return;
            }



            string [] readallusernames = File.ReadAllLines(path);
            string [] readallpasswords = File.ReadAllLines(path2);

            int data = Array.IndexOf(readallusernames, username);

            MessageBox.Show(readallusernames + "," + readallpasswords);

            if (data >= 0 && data < readallpasswords.Length)

                if (readallpasswords [data] == password)
            {
                MessageBox.Show("");
                Main main = new Main();
                main.Show();
            }
            else
            {
                MessageBox.Show("Brugernavn eller Adgangskode er forkert!");
            }
            this.Hide();



        }

        private void Signup1_Click(object sender, EventArgs e)
        {
            InitializeComponent();

            this.Hide();

            Form2 form2 = new Form2();
            form2.Show();


        }
    }
}
