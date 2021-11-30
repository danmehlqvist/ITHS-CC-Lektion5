using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_slut
{
    public class DatabaseSaver : IDataSaver
    {
        private readonly string _connectionString;

        public DatabaseSaver(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void Save(string[] lines)
        {
            var conn = new SqlConnection(_connectionString);
            conn.Open();
            foreach (string line in lines)
            {
                string[] columns = line.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
                var command = conn.CreateCommand();
                command.CommandText = "INSERT INTO People (FirstName, LastName, Email) VALUES (@FirstName, @LastName, @Email)";
                command.Parameters.AddWithValue("@FirstName", columns[0]);
                command.Parameters.AddWithValue("@LastName", columns[1]);
                command.Parameters.AddWithValue("@Email", columns[2]);
                command.ExecuteNonQuery();
            }
            conn.Close();
        }
      
    }
}
