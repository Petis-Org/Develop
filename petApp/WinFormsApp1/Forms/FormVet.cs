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
using WinFormsApp1.Forms.FormsSecundar;

namespace WinFormsApp1.Forms
{
    public partial class FormVet : Form
    {
        public List<Vet> listVet()
        {
            string querySelect = "SELECT * FROM VET";
            var connection = new petsCad();
            var list = connection.SelectCommandVet(querySelect);
            return list;
        }

        public FormVet()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            controlVetContact frm = new controlVetContact();
            frm.Show();
        }

        private void gridPets_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            controlVetRequest frm2 = new controlVetRequest();
            frm2.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            controlVetRequest frm2 = new controlVetRequest();
            frm2.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            controlVetContact frm = new controlVetContact();
            frm.Show();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void FormVet_Load(object sender, EventArgs e)
        {
            var vets = listVet();
            foreach (var vet in vets)
            {
                dataGridView2.Rows.Add(vet.Nome, vet.Avaliacao, vet.Telefone, vet.Email);
            }
        }
    }
}
