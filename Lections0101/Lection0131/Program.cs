using System.Net.Http.Headers;

Console.WriteLine("inheritance");

Person person = new(20, "Ivanov");
person.ShowInfo();
Console.WriteLine(person.ToString());
Console.WriteLine(person);

Worker worker = new(20, "Ivanov", "Cleaner");
worker.ShowInfo();
Console.WriteLine(worker.ToString());
Console.WriteLine(worker);