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
    public partial class controlPetshopRequest : Form
    {
        public List<string> listRacao(string querySelect)
        {
            var connection = new petsCad();
            var list = connection.SelectCommandObject(querySelect);
            return list;
        }

        private void selectComboTypes()
        {
            string value = comboServ.SelectedItem.ToString();
            if (value == "Ração")
            {
                comboMarca.Visible = true;
                lblMarc.Visible = true;
                comboQuant.Visible = true;
                lblQuant.Visible = true;

                comboBrinquedos.Visible = false;
                lblBrinq.Visible = false;
                comboMed.Visible = false;
                lblMed.Visible = false;
            }
            else if (value == "Brinquedos")
            {
                comboBrinquedos.Visible = true;
                lblBrinq.Visible = true;

                comboMarca.Visible = false;
                lblMarc.Visible = false;
                comboQuant.Visible = false;
                lblQuant.Visible = false;
                comboMed.Visible = false;
                lblMed.Visible = false;
            }
            else if (value == "Medicamentos")
            {
                comboMed.Visible = true;
                lblMed.Visible = true;

                comboMarca.Visible = false;
                lblMarc.Visible = false;
                comboQuant.Visible = false;
                lblQuant.Visible = false;
                comboBrinquedos.Visible = false;
                lblBrinq.Visible = false;
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

        private void comboAnimal_SelectedIndexChanged(object sender, EventArgs e)
        {
            string querySelect = "";

            if (comboServ.Text == "Ração")
            {
                querySelect = $"SELECT * FROM RACAO WHERE SERVICO = '{comboServ.Text}' AND MARCA = '{comboMarca.Text}' AND QUANTIDADE = '{comboQuant.Text}' AND ANIMAL = '{comboAnimal.Text}'";
            }
            else if (comboServ.Text == "Medicamentos")
            {
                querySelect = $"SELECT * FROM MEDICAMENTO WHERE SERVICO = '{comboServ.Text}' AND MEDICAMENTO = '{comboMed.Text}' AND ANIMAL = '{comboAnimal.Text}'";
            }
            else if (comboServ.Text == "Brinquedos")
            {
                querySelect = $"SELECT * FROM BRINQUEDO WHERE SERVICO = '{comboServ.Text}' AND BRINQUEDO = '{comboBrinquedos}' AND ANIMAL = '{comboAnimal.Text}'";
            }

            var servico = listRacao(querySelect);
            List<string> list = new List<string>();

            foreach (var item in servico)
            {
                list.Add(item.ToString());
            }

            textPreco.Text = list[list.Count - 1].ToString();
        }

        private void comboAnimal_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
