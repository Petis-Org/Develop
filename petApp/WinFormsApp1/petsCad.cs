using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using System.Configuration;
using WinFormsApp1;


namespace dbClassLibra
{
    

    public class petsCad
    {
        //private readonly string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
        public void CreateCommand(string queryString){
            
            using (var connection = new SqlConnection("Server = tcp:petisserver.database.windows.net,1433; Initial Catalog = PetisDB; Persist Security Info = False; User ID = JoaoGabrielJG; Password =Ooudh2934@!)*)@; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30;"))
            {
                SqlCommand command = new SqlCommand(queryString,
                    connection);
                command.Connection.Open();
                command.ExecuteNonQuery();
            }
        }
        public List<Pets> SelectCommand(string queryString)
        {
            var list = new List<Pets>();

            using (var connection = new SqlConnection("Server = tcp:petisserver.database.windows.net,1433; Initial Catalog = PetisDB; Persist Security Info = False; User ID = JoaoGabrielJG; Password =Ooudh2934@!)*)@; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30;"))
            {
                var command = new SqlCommand(queryString, connection);
                    command.Connection.Open();
                    var Reader = command.ExecuteReader();

                while (Reader.Read())
                {
                    list.Add(new Pets
                    {
                        Animal = Reader.GetString(0),
                        Raca = Reader.GetString(1),
                        Estado = Reader.GetString(2),
                        Cidade = Reader.GetString(3),
                        Sexo = Reader.GetString(4),
                        Tempo = Reader.GetString(5)
                    });
                }

                return list;
            }
        }

        public List<Vet> SelectCommandVet (string queryString) {
            var list = new List<Vet>();
            using (var connection = new SqlConnection("Server = tcp:petisserver.database.windows.net,1433; Initial Catalog = PetisDB; Persist Security Info = False; User ID = JoaoGabrielJG; Password =Ooudh2934@!)*)@; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30;"))
            {
                var command = new SqlCommand (queryString, connection);
                command.Connection.Open();
                var Reader = command.ExecuteReader();

                while (Reader.Read())
                {
                    list.Add(new Vet
                    {
                        Nome = Reader.GetString(0),
                        Avaliacao = Reader.GetDouble(1),
                        Telefone = Reader.GetString(2),
                        Email = Reader.GetString(3)
                    });
                }
            }
            return list;
        }

        public List<petShop> SelectCommandPetShop (string queryString)
        {
            var list = new List<petShop>(); 
            using (var connection = new SqlConnection("Server = tcp:petisserver.database.windows.net,1433; Initial Catalog = PetisDB; Persist Security Info = False; User ID = JoaoGabrielJG; Password =Ooudh2934@!)*)@; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30;"))
            {
                var command = new SqlCommand (queryString, connection);
                command.Connection.Open();
                var Reader = command.ExecuteReader();

                while (Reader.Read())
                {
                    list.Add(new petShop
                    {
                        Petshop = Reader.GetString(0),
                        Avaliacao = Reader.GetDouble(1),
                        Telefone = Reader.GetString(2),
                        Endereco = Reader.GetString(3)
                    });
                }
                return list;
            }
        }

        public List<vetRequest> SelectCommandVetReq (string queryString)
        {
            var list = new List<vetRequest>();
            using ( var connection = new SqlConnection("Server = tcp:petisserver.database.windows.net,1433; Initial Catalog = PetisDB; Persist Security Info = False; User ID = JoaoGabrielJG; Password =Ooudh2934@!)*)@; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30;"))
            {
                var command = new SqlCommand (queryString, connection);
                command.Connection.Open();
                var Reader = command.ExecuteReader();

                while (Reader.Read())
                {
                    list.Add(new vetRequest
                    {
                        Servico = Reader.GetString(0),
                        Animal = Reader.GetString(1),
                        Preco = Reader.GetString(2)
                    });
                }
                return list;
            }
        }
    }
}