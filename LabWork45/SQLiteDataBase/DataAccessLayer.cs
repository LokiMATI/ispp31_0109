using Microsoft.Data.Sqlite;
using System.Data;

namespace SQLiteDataBase
{
    public static class DataAccessLayer
    {
        public static string DataBase { get; set; } = "sqlite.db";
        public static string ConnectionString
        {
            get
            {
                SqliteConnectionStringBuilder builder = new()
                {
                    DataSource = DataBase
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
                    using SqliteConnection connection = new(ConnectionString);
                    connection.Open();

                    List<Game> games = new();

                    SqliteCommand command = new("SELECT * FROM Games", connection);
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
                using SqliteConnection connection = new(ConnectionString);
                connection.Open();

                SqliteCommand command = new(query, connection);
                return command.ExecuteScalar();
            }
            catch (Exception)
            {
                return new();
            }
        }

        public static DataTable GetDataTable(string query)
        {
            try
            {
                using SqliteConnection connection = new(ConnectionString);
                connection.Open();

                SqliteCommand command = new(query, connection);
                var reader = command.ExecuteReader();

                DataTable dataTable = new();

                dataTable.Load(reader);

                return dataTable;
            }
            catch (Exception)
            {
                return new();
            }
        }
    }
}
