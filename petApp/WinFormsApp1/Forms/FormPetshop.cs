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
    public partial class FormPetshop : Form
    {
        public FormPetshop()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FormPetshop_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void gridPets_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            controlPetshopRequest frm2 = new controlPetshopRequest();
            frm2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            controlPetshopContact frm = new controlPetshopContact();
            frm.Show();
        }

        private void FormPetshop_Load_1(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            controlPetshopRequest frm2 = new controlPetshopRequest();
            frm2.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            controlPetshopContact frm = new controlPetshopContact();
            frm.Show();
        }
    }
}
