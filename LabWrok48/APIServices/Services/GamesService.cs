using ApiServices.Models;
using System.Net.Http.Json;

namespace ApiServices.Services;

public class GamesService(HttpClient httpClient)
{
    private readonly HttpClient _httpClient = httpClient;

    public async Task<IEnumerable<Game>> GetGamesAsync()
    {
        var games = await _httpClient.GetFromJsonAsync<IEnumerable<Game>>("/Games");

        if (games is null)
            throw new Exception("Данные не получены.");

        return games;
    }

    public async Task<Game> GetGameByIdAsync(int id)
    {
        var game = await _httpClient.GetFromJsonAsync<Game>($"/Games/{id}");

        if (game is null)
            throw new Exception("Данные не получены.");

        return game;
    }

    public async Task CreateGameAsync(Game game)
    {
        var response = await _httpClient.PostAsJsonAsync("/Games", game);

        await CheckConnection(response);
    }

    public async Task UpdateGameAsync(Game game)
    {
        var response = await _httpClient.PutAsJsonAsync("/Games", game);

        await CheckConnection(response);
    }

    public async Task DeleteGameAsync(int id)
    {
        var response = await _httpClient.DeleteAsync($"/Games/{id}");

        await CheckConnection(response);

        if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
            throw new KeyNotFoundException("Игра с данным идентификатором не была найдена.");
    }

    private static async Task CheckConnection(HttpResponseMessage response)
    {
        if (response.StatusCode == System.Net.HttpStatusCode.BadRequest || !response.IsSuccessStatusCode)
            throw new Exception(await response.Content.ReadAsStringAsync());
    }
}
