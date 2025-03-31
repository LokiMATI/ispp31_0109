public class Logger
{
    private static readonly Logger _instance = new();

    private Logger() { }

    public static Logger GetInstance() => _instance;

    public void Log(string message) => Console.WriteLine(message);
}