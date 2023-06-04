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
        public List<racao> listRacao()
        {
            string querySelect = $"SELECT * FROM RACAO WHERE SERVICO = '{comboServ}' AND MARCA = '{comboMarca}' AND QUANTIDADE = '{comboQuant}' AND ANIMAL = '{comboAnimal}'";
            var connection = new petsCad();
            var list = connection.SelectCommandRacao(querySelect);
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
            var servico = listRacao();
            var preco = "";

            foreach (var racao in servico)
            {
                preco = racao.Preco;
            }
            textPreco.Text = preco.ToString();
        }
    }
}
