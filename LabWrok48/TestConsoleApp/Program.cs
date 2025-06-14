using ApiServices.Services;

try
{
    HttpClient httpClient = new();
    httpClient.BaseAddress = new("http://localhost:5177");

    GamesService service = new(httpClient);
    var games = await service.GetGamesAsync();
    var game = await service.GetGameByIdAsync(5);
    game = new()
    {
        Id = 15,
        Title = "Тестовая запись",
        Description = "Тестовое описание",
        Price = 10,
        PublicationYear = 100
    };
    //await service.CreateGameAsync(game);
    //game.Description = "Измённйное тестовое описание.";
    await service.UpdateGameAsync(game);
    //await service.DeleteGameAsync(13);
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
