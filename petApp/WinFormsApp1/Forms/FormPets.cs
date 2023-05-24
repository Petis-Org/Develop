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
    public partial class FormPets : Form
    {
        public FormPets()
        {
            InitializeComponent();
        }

        private void FormPets_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            controlAdote frm = new controlAdote();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            controlCadPet frm2 = new controlCadPet();
            frm2.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView2.Rows.Add(e.RowIndex, e.ColumnIndex);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            controlCadPet frm2 = new controlCadPet();
            frm2.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            controlAdote frm = new controlAdote();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
