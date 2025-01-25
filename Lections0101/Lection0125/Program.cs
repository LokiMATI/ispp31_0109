Console.WriteLine("lection 01/25");

Cat murka = new();

Random random = new();
DateTime birthday = new(2005, 1, 25);

var person = new Person();
//person.fullName = "qwe0";

Person.Country = "asd";

person.Print();

Person.Country = "zxc";

person.Print();