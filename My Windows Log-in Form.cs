namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Define your specific password
            string specificPassword = "Bacani";

            // Check if both the username and password match the desired values
            if (textBox1.Text == "Christiane" && textBox2.Text == specificPassword)
            {
                // Display a success message if both username and password match
                MessageBox.Show("Successfully entered your account!");


            }
            else
            {
                // Display an error message if either username or password is incorrect
                MessageBox.Show("Incorrect username or password. Please try again.");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Define your specific username
            string specificUsername = "Christiane";

            // Check if the text in the TextBox matches the specific username
            if (textBox1.Text == specificUsername)
            {
                // Enable the button when the specific username is entered
                button1.Enabled = true;
            }
            else
            {
                // Disable the button if the entered text does not match the specific username
                button1.Enabled = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
