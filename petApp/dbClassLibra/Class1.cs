using System.Data.SqlClient;


namespace dbClassLibra
{

    //https://learn.microsoft.com/pt-br/dotnet/api/system.data.sqlclient.sqlconnection?view=dotnet-plat-ext-7.0

    public class Class1
    {
        private static void CreateCommand(string queryString,
            string connectionString){
            
            using (SqlConnection connection = new SqlConnection("tcp:petisserver.database.windows.net,1433; Initial Catalog = PetisDB; Persist Security Info = False; User ID = JoaoGabrielJG; Password =Ooudh2934@!)*)@; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30;"))
            {
                SqlCommand command = new SqlCommand(queryString,
                    connection);
                command.Connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}