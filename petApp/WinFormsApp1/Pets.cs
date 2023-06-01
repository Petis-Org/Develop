using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Pets
    {
            public string Animal { get; set; }
            public string Raca { get; set; }
            public string Estado { get; set; }
            public string Cidade { get; set; }
            public string Sexo { get; set; }
            public string Tempo { get; set; }
     
    }

    public class Vet
    {
        public string Nome { get; set; }
        public double Avaliacao { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
    }

    public class petShop
    {
        public string Petshop { get; set; }
        public double Avaliacao { get; set; }
        public string Telefone { get; set;}
        public string Endereco { get; set; }
    }

    public class vetRequest
    {
        public string Servico { get; set;}
        public string Animal { get; set; }
        public string Preco { get; set; }
    }
}
