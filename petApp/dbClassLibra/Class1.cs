

namespace dbClassLibra
{

    //https://learn.microsoft.com/pt-br/dotnet/api/system.data.sqlclient.sqlconnection?view=dotnet-plat-ext-7.0

    public class Class1
    {
        private static void CreateCommand(string queryString,
            string connectionString){
            
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString,
                    connection);
                object value = command.Connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}