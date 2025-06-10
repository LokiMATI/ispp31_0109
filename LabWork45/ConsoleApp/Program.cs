using MSSQL = LabWork46Library;
using SQLite= SQLiteDataBase;

// Задание 1
Console.WriteLine(MSSQL.DataAccessLayer.ConnectionString);
Console.WriteLine(SQLite.DataAccessLayer.ConnectionString);

// Задание 2
MSSQL.DataAccessLayer.Login = "ispp3102";
MSSQL.DataAccessLayer.Password = "3102";
MSSQL.DataAccessLayer.DataBase = "ispp3102";


Console.WriteLine(MSSQL.DataAccessLayer.GetScalarValue("SELECT * FROM GAME"));
try
{
    Console.WriteLine(SQLite.DataAccessLayer.GetScalarValue("SELECT * FROM Games"));
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}


// Задание 3
var mssqlResult = MSSQL.DataAccessLayer.Games;

var sqliteResult = SQLite.DataAccessLayer.Games;

// Задание 4
var mssqlDataTable = MSSQL.DataAccessLayer.GetDataTable("SELECT * FROM Game");
var sqliteDataTable = SQLite.DataAccessLayer.GetDataTable("SELECT * FROM Game");

Console.ReadLine();