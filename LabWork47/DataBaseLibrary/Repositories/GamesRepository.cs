using Dapper;
using DataBaseLibrary.DatabaseConnections;
using DataBaseLibrary.Models;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DataBaseLibrary.Repositories;

public class GamesRepository(IDbConnectionFactory factory)
{
    private readonly IDbConnection _db = factory.CreateConnection();

    public async Task<IEnumerable<Game>> GetAll()
        => await _db.QueryAsync<Game>(
            "SELECT * FROM Game");

    public async Task<Game?> GetById(int id)
    {
        var game = _db.QueryFirstOrDefault<Game>(
            "SELECT * FROM Game WHERE Id=@id",
            new { id });

        if (game is null)
            throw new KeyNotFoundException();

        return game;
    }

    public async Task Create(Game game)
        => await _db.ExecuteAsync(
            "INSERT INTO Game([Title], [Price]) VALUES(@Title, @Price)", game);
}
