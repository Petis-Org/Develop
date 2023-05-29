using System.Data.SqlClient;


namespace dbClassLibra
{

    //https://learn.microsoft.com/pt-br/dotnet/api/system.data.sqlclient.sqlconnection?view=dotnet-plat-ext-7.0

    public class petsCad
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

        public void CreateCommand(string queryString){
            
            using (SqlConnection connection = new SqlConnection("server=tcp:petisserver.database.windows.net,1433; Initial Catalog = PetisDB; Persist Security Info = False; User ID = JoaoGabrielJG; Password =Ooudh2934@!)*)@; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30;"))
            {
                SqlCommand command = new SqlCommand(queryString,
                    connection);
                command.Connection.Open();
                command.ExecuteNonQuery();
            }
        }
        public void SelectCommand(string queryString)
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
            }
        }
    }
}