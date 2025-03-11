<Query Kind="Statements" />

DirectoryInfo directory = new DirectoryInfo(@"C:\temp\ispp31");
FileInfo[] files = directory.GetFiles("*", SearchOption.AllDirectories);

//Задание 1
//var sortedFiles = files
//    .Select(f => new { f.Name, f.DirectoryName, f.Length, f.CreationTime })
//    .OrderBy(f => f.Name)
//    .ThenByDescending(f => f.CreationTime)
//    .Dump();

// Задание 2
Console.Write("Введите название файла: ");
string search = Console.ReadLine();

var searchedFiles = files
    .Where(f => f.Name.Contains(search)).Dump();
var countSearchedFiles = files
    .Count(f => f.Name.Contains(search)).Dump();

// Задание 3
var extension = files.Select(f => f.Extension).Distinct()
    .Dump();

var extensionCount = files.GroupBy(f => f.Extension)
    .Select(f => new { f.Key, Count = f.Count() })
    .Dump();
	
// Задание 4
var todayFiles = files.Where(f => f.CreationTime.Date == DateTime.Today).OrderByDescending(f => f.CreationTime).Take(10).Dump();

// Задание 5
var fileInfos = files
    .Select(f => new
    {
        f.Name,
        f.Extension,
        f.DirectoryName,
        Length = f.Length >= 1_000_000 ? $"{f.Length >> 20} МБ" : f.Length >= 1000 ? $"{f.Length >> 10} КБ" : $"{f.Length} Б"
    }
    ).Dump();