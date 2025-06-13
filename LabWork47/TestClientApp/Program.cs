using DataBaseLibrary.DatabaseConnections;
using DataBaseLibrary.Repositories;
using DataBaseLibrary.Services;

internal class Program
{
    private static async Task Main(string[] args)
    {
        try
        {
            IDbConnectionFactory factory = new MSSqlFactory("Data Source=mssql;Initial Catalog=ispp3102;User ID=ispp3102;Password=3102;Trust Server Certificate=True");
            GamesRepository repository = new(factory);
            GamesService service = new(repository);

            var games = await service.GetGamesAsync();

            var game = await service.GetGameByIdAsync(5);

            game = new()
            {
                Id = 13,
                Title = "Тест игра2",
                PublicationYear = (short)DateTime.Today.Year,
                Price = 29
            };

            //await service.CreateGameAsync(game);
            //await service.UpdateGameAsync(game);
            await service.DeleteGameAsync(13);

            Console.ReadLine();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        
    }
}