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
            string querySelect = "SELECT * FROM VETREQUEST";
            var connection = new petsCad();
            var list = connection.SelectCommandVetReq(querySelect);
            return list;
        }
        public controlVetRequest()
        {
            InitializeComponent();
        }
    }
}
