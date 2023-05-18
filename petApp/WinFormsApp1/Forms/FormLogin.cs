using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1.Forms
{
    public partial class FormLogin : Form
    {
        private string username = "CaioPedroNat";
        private string password = "LeoGostoso123";
        public FormLogin()
        {
            InitializeComponent();
        }

        private void validarLogin(string usernameDigitado, string passwordDigitado)
        {
            if (username == usernameDigitado && password == passwordDigitado)
            {
                Form1 home = new Form1();
                home.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login invalido");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
            {
                validarLogin(textBox2.Text, textBox1.Text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.UseSystemPasswordChar == true)
            {
                textBox1.UseSystemPasswordChar = false;
            }
            else
            {
                textBox1.UseSystemPasswordChar = true;
            }
        }
    }
}
