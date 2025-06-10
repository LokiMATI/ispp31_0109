using Microsoft.Data.SqlClient;
using System.Data;

namespace LabWork46Library
{
    public static class DataAccessLayer
    {
        public static string Host { get; set; } = "mssql";
        public static string DataBase { get; set; } = "ispp3113";
        public static string Login { get; set; } = "ispp3113";
        public static string Password { get; set; } = "3113";

        public static string ConnectionString
        {
            get
            {
                SqlConnectionStringBuilder builder = new()
                {
                    DataSource = Host,
                    InitialCatalog = DataBase,
                    UserID = Login,
                    Password = Password,
                    TrustServerCertificate = true
                };

                return builder.ConnectionString;
            }
        }

        public static List<Game> Games
        {
            get
            {
                try
                {
                    using SqlConnection connection = new(ConnectionString);
                    connection.Open();

                    List<Game> games = new();

                    SqlCommand command = new("SELECT * FROM Games", connection);
                    var reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            games.Add(new Game()
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                Title = Convert.ToString(reader["Title"]),
                                Price = Convert.ToDouble(reader["Price"])
                            });
                        }
                    }

                    return games;
                }
                catch (Exception)
                {
                    return new();
                }
            }
        }

        public static object GetScalarValue(string query)
        {
            try
            {
                using SqlConnection connection = new(ConnectionString);
                connection.Open();

                SqlCommand command = new(query, connection);
                return command.ExecuteScalar();
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public static DataTable GetDataTable(string query)
        {
            try
            {
                using SqlConnection connection = new(ConnectionString);
                connection.Open();

                SqlCommand command = new(query, connection);
                DataTable dataTable = new();
                using var adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(dataTable);

                return dataTable;
            }
            catch (Exception)
            {
                return new();
            }
        }
    }
}
