using Dapper;
using DataBaseLibrary.DatabaseConnections;
using DataBaseLibrary.Models;
using System.Data;

namespace DataBaseLibrary.Repositories;

public class GamesRepository(IDbConnectionFactory factory)
{
    private readonly IDbConnection _db = factory.CreateConnection();

    public IEnumerable<Game> GetAll()
        => _db.Query<Game>(
            "SELECT * FROM Game;");

    public Game? GetById(int id)
    {
        var game = _db.QueryFirstOrDefault<Game>(
            "SELECT * FROM Game WHERE Id=@id;",
            new { id });

        return game;
    }

    public void Create(Game game)
        => _db.Execute(
            @"INSERT INTO Game(Title, Description, PublicationYear, Price) 
VALUES(@Title, @Description, @PublicationYear, @Price)",
            game);

    public int Update(Game game)
        => _db.Execute(
            @"UPDATE Game 
SET Title = @Title, 
Price = @Price,
Description = @Description,
PublicationYear = @PublicationYear
WHERE Id = @Id;",
            game);

    public async Task<int> DeleteAsync(int id)
        => await _db.ExecuteAsync(
            "DELETE Game WHERE Id=@id", new { id });
}
