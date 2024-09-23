namespace WinFormsApp1
{
    public partial class Menu : Form
    {
        private string[] data;
        public Menu(string loginName)
        {
            InitializeComponent();
            label2.Text = loginName;
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

     

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 1)
            {
                Login frm2 = new Login();
                this.Hide();

                frm2.Closed += (s, args) => this.Close();
                frm2.Show();

            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 1)
            {
                var form2 = new Fungsi();
                form2.Show();
                

            }
        }
    }
}
