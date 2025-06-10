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
                            Title = reader["Title"].ToString(),
                            Price = Convert.ToDouble(reader["Price"])
                        });
                    }
                }

                return games;
            }
        }

        public static object GetScalarValue(string query)
        {
            using SqliteConnection connection = new(ConnectionString);
            connection.Open();

            SqliteCommand command = new(query, connection);
            return command.ExecuteScalar();
        }

        public static DataTable GetDataTable(string query)
        {
            using SqliteConnection connection = new(ConnectionString);
            connection.Open();

            SqliteCommand command = new(query, connection);
            var reader = command.ExecuteReader();

            DataTable dataTable = new();
            dataTable.Load(reader);

            return dataTable;
        }
    }
}
