using System.Security.Cryptography;
using System.Text;

namespace WinFormsApp1
{
    public partial class Fungsi : Form
    {
        public Fungsi()
        {
            InitializeComponent();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void Fungsi_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox2.Text);
        }

        

        private void button4_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox3.Text);
        }
        public static string Encrypt(string plainText, string password = null)
        {
            var data = Encoding.Default.GetBytes(plainText);
            var pwd = !string.IsNullOrEmpty(password) ? Encoding.Default.GetBytes(password) : Array.Empty<byte>();
            var cipher = ProtectedData.Protect(data, pwd, DataProtectionScope.CurrentUser);
            return Convert.ToBase64String(cipher);
        }

        public static string Decrypt(string cipherText, string password = null)
        {
            try
            {
                var cipher = Convert.FromBase64String(cipherText);
                var pwd = !string.IsNullOrEmpty(password) ? Encoding.Default.GetBytes(password) : Array.Empty<byte>();
                var data = ProtectedData.Unprotect(cipher, pwd, DataProtectionScope.CurrentUser);
                return Encoding.Default.GetString(data);
            }
            catch (Exception)
            {
                MessageBox.Show("kalimat yang dimasukan bukan encrypter");
                return "";
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "mykey" && textBox2.Text!= "")
                textBox3.Text = Encrypt(textBox2.Text, textBox1.Text);
            else
            {
                MessageBox.Show("Key yang dimasukan salah atau ada yang belum lengkap");
                textBox3.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "mykey"&&textBox3.Text!="")
                textBox2.Text = Decrypt(textBox3.Text, textBox1.Text);
            else
            {
                MessageBox.Show("Key yang dimasukan salah atau ada yang belum lengkap");
                textBox2.Text = "";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
