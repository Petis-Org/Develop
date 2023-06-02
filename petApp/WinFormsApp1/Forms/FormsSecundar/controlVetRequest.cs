using dbClassLibra;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1.Forms.FormsSecundar
{
    public partial class controlVetRequest : Form
    {
        public List<vetRequest> listVetReq()
        {
            string querySelect = $"SELECT * FROM VETREQUEST WHERE SERVICO = '{comboBox5.Text}' AND ANIMAL = '{comboBox4.Text}'";
            var connection = new petsCad();
            var list = connection.SelectCommandVetReq(querySelect);
            return list;
        }
        public controlVetRequest()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_TextChanged(object sender, EventArgs e)
        {
            var servico = listVetReq();
            var preco = "";

            foreach (var vetReq in servico)
            {
                preco = vetReq.Preco;
            }
            textBox1.Text = preco.ToString();
        }
    }
}
