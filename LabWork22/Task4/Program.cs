using System.Security.Cryptography;

string[] fileNames = Directory.GetFiles(@"C:\temp\ispp31\LabWork22\Task4\bin\Debug\net9.0\МДК.01.01");

foreach (var fileName in fileNames)
    await CalculateFileHash(fileName);

static string CalculateHash(byte[] data)
{
    using var sha256 = SHA256.Create();
    return Convert.ToHexString(sha256.ComputeHash(data));
}

static async Task CalculateFileHash(string fileName)
{
    var bytes = await File.ReadAllBytesAsync(fileName);
    string fileHash = await Task.Run(() => CalculateHash(bytes));
    Console.WriteLine($"{fileName} : {CalculateHash(bytes)}");
}