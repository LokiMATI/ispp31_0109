using Microsoft.Data.SqlClient;

namespace LabWork46Library;

public class SqlDatabase : IDatabase
{
    private readonly string _connectionString;
    public SqlDatabase(
        string host = "mssql",
        string dataBase = "ispp3102",
        string login = "ispp3102",
        string password = "3102")
    {
        SqlConnectionStringBuilder builder = new()
        {
            DataSource = host,
            InitialCatalog = dataBase,
            UserID = login,
            Password = password,
            TrustServerCertificate = true
        };

        _connectionString = builder.ConnectionString;
    }

    public int ExecuteQuery(string query)
    {
        using SqlConnection connection = new(_connectionString);
        connection.Open();

        SqlCommand command = new(query, connection);

        return command.ExecuteNonQuery();
    }

    public int InsertGame(
        string title,
        double price,
        DateTime date)
    {
        using SqlConnection connection = new(_connectionString);
        connection.Open();

        SqlCommand command = new($"INSERT INTO Game ([Title], [PublicationYear], [Price]) VALUES (@title, @date, @price)", connection);

        command.Parameters.AddWithValue("@title", title);
        command.Parameters.AddWithValue("@date", date.Year);
        command.Parameters.AddWithValue("@price", price);

        return command.ExecuteNonQuery();
    }

    public bool UpdateGame(Game game)
    {
        using SqlConnection connection = new(_connectionString);
        connection.Open();

        SqlCommand command = new($"UPDATE Game SET Title = '{game.Title}', Price = {game.Price} WHERE Id = {game.Id};", connection);

        return command.ExecuteNonQuery() == 1;
    }
}
