using Excel = Microsoft.Office.Interop.Excel;
Console.Write("Напишите путь до папки: ");
string path = Console.ReadLine();

if (!Directory.Exists(path))
{
    Console.WriteLine("Данной папки не существует.");
    return;
}

DirectoryInfo directory = new(path);
var files = directory.GetFiles();

const string Template = "template.xlsx";
const string FolderContents = "Folder contents.xlsx";

var excelApp = new Excel.Application();
var workbook = excelApp.Workbooks.Add(Template);
var workSheet = (Excel.Worksheet)workbook.Worksheets[1];

for (int i = 2; i <= files.Length; i++)
{
    var file = files[i - 2];
    workSheet.Cells[i, 1] = i - 1;
    workSheet.Cells[i, 2] = file.Name;
    workSheet.Cells[i, 3] = file.Length;
}

var dirictories = directory.GetDirectories();

workSheet = (Excel.Worksheet)workbook.Worksheets[2];

for (int i = 2; i <= dirictories.Length; i++)
{
    directory = dirictories[i - 2];
    workSheet.Cells[i, 1] = i - 1;
    workSheet.Cells[i, 2] = directory.Name;
}

workbook.SaveAs(FolderContents);

excelApp.Quit();