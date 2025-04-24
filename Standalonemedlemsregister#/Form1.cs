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
            string path = @"C:\Users\claus\source\repos\Standalonemedlemsregister#\Standalonemedlemsregister#\Database\Cpr.txt";//Paths
            string path2 = @"C:\Users\claus\source\repos\Standalonemedlemsregister#\Standalonemedlemsregister#\Database\Password.txt";//Paths
            string path3 = @"C:\Users\claus\source\repos\Standalonemedlemsregister#\Standalonemedlemsregister#\Database\Mail.txt";//Paths
            string path4 = @"C:\Users\claus\source\repos\Standalonemedlemsregister#\Standalonemedlemsregister#\Database\Navn.txt";//Paths

            // Herunder er de forskellige data hvor der bliver hentet brugerinput fra de tekstboxe som er brugt.
            string username = Username1.Text; // Data
            string password = Password1.Text;// Data

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password)) // Her bliver der tjekket om brugernavn og adgangskode er udfyldt
            {
                MessageBox.Show("ALL SPACES NEED TO BE FILLED");
                return;
            }



            string Username = File.ReadAllText(path);
            string Password = File.ReadAllText(path2);


            if (username == Username && password == Password)
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
    }
}
