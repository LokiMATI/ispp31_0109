using System.Net.Http.Headers;
using Lection0312;
Console.WriteLine("patters");

Logger.GetInstance().Log("LOG: test singleon");
Logger.GetInstance().Log($"LOG: {DateTime.Now}");

Application application = new();
var pdf = application.Create("pdf");

IUIFactory factory = new WindownsUIFactory();
IButton button = factory.CreateButton();
button.Render();