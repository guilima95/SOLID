using Microsoft.Data.SqlClient;
using SOLID.DIP.Before.Models;
using System.Data;

namespace SOLID.DIP.Before.Repositories
{
    public class ClientRepository
    {
        public async Task AddClient(Client client)
        {
            using var connection = new SqlConnection();

            var sqlCommand = new SqlCommand();

            connection.ConnectionString = "connectionString";
            sqlCommand.Connection = connection;
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "INSERT INTO Client (Name, Email, Date) Values (@name, @email, @date)";

            sqlCommand.Parameters.AddWithValue("name", client.Name);
            sqlCommand.Parameters.AddWithValue("email", client.Email?.Address);
            sqlCommand.Parameters.AddWithValue("date", client.Date);

            connection.Open();
            sqlCommand.ExecuteNonQuery();

            await Task.CompletedTask;
        }
    }
}