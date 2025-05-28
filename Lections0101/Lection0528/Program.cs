using Lection0528;
using System.Configuration;
using System.Text.Json;

Console.WriteLine("settings");
/*
// txt
string fileName = "settings.txt";
var txt = File.ReadAllText(fileName);

// csv
fileName = "settings.csv";
var csv = File.ReadAllLines(fileName);
foreach (var line in csv)
{
    var cells = line.Split(';');
    var login = cells[0];
    var password = cells[1];
    var age = int.Parse(cells[2]);
}

// xml
*/
// json
string fileName = "Users.json";
string json = File.ReadAllText(fileName);

JsonSerializerOptions options = new()
{
    PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
};

var users = JsonSerializer.Deserialize<List<User>>(json, options);

options = new()
{
    WriteIndented = true,
    PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
};

json = JsonSerializer.Serialize<List<User>>(users, options);

var login = ConfigurationManager.AppSettings["Login"];
var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
config.AppSettings.Settings["Login"].Value = "Менеджер";
config.Save();
ConfigurationManager.RefreshSection("appSettings");
Console.WriteLine();


