using dbClassLibra;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1.Forms.FormsSecundar
{
    public partial class controlCadPet : Form
    {

        public void Add(Pets pets)
        {
            try
            {
                string queryCad = "INSERT INTO PETSADOTE " +
                $"VALUES ('{pets.Animal}', '{pets.Raca}', '{pets.Estado}', '{pets.Cidade}', '{pets.Sexo}','{pets.Tempo}')";
                var connection = new petsCad();
                connection.CreateCommand(queryCad);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private Pets Leo()
        {
            var pet = new Pets
            {
                Animal = comboBox5.Text,
                Raca = textBox2.Text,
                Estado = comboBox2.Text,
                Cidade = textBox1.Text,
                Sexo = comboBox4.Text,
                Tempo = comboBox6.Text
            };

            return pet;
        }

        public controlCadPet()
        {
            InitializeComponent();
        }

        private void controlCadPet_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var pet = Leo();
            Add(pet);
            this.Close();
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

