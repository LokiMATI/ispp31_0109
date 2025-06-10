using Microsoft.Data.Sqlite;

namespace LabWork46Library;

public class SqliteDatabase : IDatabase
{
    private readonly string _connectionString;
    public SqliteDatabase(
        string dataBase,
        string path = "")
    {
        SqliteConnectionStringBuilder builder = new()
        {
            DataSource = Path.Combine(path, dataBase),
        };

        _connectionString = builder.ConnectionString;
    }

    public int ExecuteQuery(string query)
    {
        using SqliteConnection connection = new(_connectionString);
        connection.Open();

        SqliteCommand command = new(query, connection);

        return command.ExecuteNonQuery();
    }

    public int InsertGame(
        string title,
        double price,
        DateTime date)
    {
        using SqliteConnection connection = new(_connectionString);
        connection.Open();

        SqliteCommand command = new($"INSERT INTO Game (Title, PublicationYear, Price) VALUES (@title, @date, @price)", connection);

        command.Parameters.AddWithValue("@title", title);
        command.Parameters.AddWithValue("@date", date.Year);
        command.Parameters.AddWithValue("@price", price);

        return command.ExecuteNonQuery();
    }

    public bool UpdateGame(Game game)
    {
        using SqliteConnection connection = new(_connectionString);
        connection.Open();

        SqliteCommand command = new($"UPDATE Game SET Title = '{game.Title}', Price = {game.Price} WHERE Id = {game.Id};", connection);

        return command.ExecuteNonQuery() == 1;
    }
}
