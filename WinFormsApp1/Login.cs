using Microsoft.VisualBasic;

namespace WinFormsApp1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "iwan" && textBox2.Text == "password123")
            {
                Menu frm2 = new Menu(textBox1.Text);
                this.Hide();

                frm2.Closed += (s, args) => this.Close();
                frm2.Show();
            }
            else
                MessageBox.Show("Username Or Password Incorrent Try Again!");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}
