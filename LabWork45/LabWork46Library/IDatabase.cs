namespace LabWork46Library;

public interface IDatabase
{
    int ExecuteQuery(string query);
    bool UpdateGame(Game game);
    int InsertGame(string title, double price, DateTime date);

}
