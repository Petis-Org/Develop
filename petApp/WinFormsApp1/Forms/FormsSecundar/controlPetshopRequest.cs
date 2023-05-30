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
    public partial class controlPetshopRequest : Form
    {
        private void selectComboTypes()
        {
            string value = comboServ.SelectedItem.ToString();
            if (value == "Ração")
            {
                comboMarca.Visible = true;
                lblMarc.Visible = true;
                comboQuant.Visible = true;
                lblQuant.Visible = true;
            }
            else if (value == "Brinquedos")
            {
                comboBrinquedos.Visible = true;
                lblBrinq.Visible = true;
            }
            else if (value == "Medicamentos")
            {
                comboMed.Visible = true;
                lblMed.Visible = true;
            }
        }

        public controlPetshopRequest()
        {
            InitializeComponent();
        }

        private void controlPetshopRequest_Load(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectComboTypes();
        }
    }
}
