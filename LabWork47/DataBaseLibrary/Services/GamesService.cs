using DataBaseLibrary.Models;
using DataBaseLibrary.Repositories;

namespace DataBaseLibrary.Services;

public class GamesService(GamesRepository repository)
{
    private readonly GamesRepository _repository = repository;

    public async Task<IEnumerable<Game>> GetGamesAsync()
    {
        Console.WriteLine($"{DateTime.Now}: Отправлен запрос на получение всех игр.");
        var games = await Task.Run(() => _repository.GetAll());
        Console.WriteLine($"{DateTime.Now}: Список игр получены.");

        return games;
    }

    public async Task<Game?> GetGameByIdAsync(int id)
    {
        ValidateId(id);

        Console.WriteLine($"{DateTime.Now}: Отправлен запрос на получение игры.");
        var game = await Task.Run(() => _repository.GetById(id));
        Console.WriteLine($"{DateTime.Now}: Игра получена.");

        return game;
    }

    public async Task CreateGameAsync(Game game)
    {
        ValidateGame(game);

        Console.WriteLine($"{DateTime.Now}: Отправлен запрос на добавление игры.");
        await Task.Run(() => _repository.Create(game));
        Console.WriteLine($"{DateTime.Now}: Игра добавлена.");
    }

    public async Task UpdateGameAsync(Game game)
    {
        ValidateGame(game);

        Console.WriteLine($"{DateTime.Now}: Отправлен запрос на обновление игры.");
        await Task.Run(() => _repository.Update(game));
        Console.WriteLine($"{DateTime.Now}: Игра обновлена.");
    }

    public async Task DeleteGameAsync(int id)
    {
        ValidateId(id);

        Console.WriteLine($"{DateTime.Now}: Отправлен запрос на удаление игры.");
        if (await _repository.DeleteAsync(id) != 1)
            Console.WriteLine($"{DateTime.Now}: Игра не найдена.");
        else
            Console.WriteLine($"{DateTime.Now}: Игра удалена.");
    }

    private static void ValidateId(int id)
    {
        if (id < 0)
            throw new ArgumentOutOfRangeException();
    }

    private static void ValidateGame(Game game)
    {
        if (game.Price < 0)
            throw new ArgumentOutOfRangeException();
        if (string.IsNullOrWhiteSpace(game.Title))
            throw new ArgumentException("Название не должно быть пустым.");
        if (game.Description is not null && game.Description == string.Empty)
            throw new ArgumentException("Описание, если оно есть, то не должно быть пустым");
    }
}
