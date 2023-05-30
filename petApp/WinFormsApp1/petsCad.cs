using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using WinFormsApp1;


namespace dbClassLibra
{

    //https://learn.microsoft.com/pt-br/dotnet/api/system.data.sqlclient.sqlconnection?view=dotnet-plat-ext-7.0

    public class petsCad
    {
        public void CreateCommand(string queryString){
            
            using (var connection = new SqlConnection("server=tcp:petisserver.database.windows.net,1433; Initial Catalog = PetisDB; Persist Security Info = False; User ID = JoaoGabrielJG; Password =Ooudh2934@!)*)@; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30;"))
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

            using (var connection = new SqlConnection("server=tcp:petisserver.database.windows.net,1433; Initial Catalog = PetisDB; Persist Security Info = False; User ID = JoaoGabrielJG; Password =Ooudh2934@!)*)@; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30;"))
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
            using (var connection = new SqlConnection("server = tcp:petisserver.database.windows.net,1433; Initial Catalog = PetisDB; Persist Security Info = False; User ID = JoaoGabrielJG; Password = Ooudh2934@!)*)@; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30;"))
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
    }
}