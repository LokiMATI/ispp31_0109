// Задание 1
Applicant applicant = new()
{
    FullName = "Иванов Иван Иванович",
    ClassNumber = 11,
    AverageScore = 5.00
};

Rectangle rectangle = new()
{
    Height = 5,
    Width = 3
};

applicant.Print();
rectangle.Print();
Console.WriteLine();

// Задание 3
IFigure figure = new Rectangle()
{
    Height = 5,
    Width = 3
};

Console.WriteLine(figure.GetSquare());
Console.WriteLine(figure.GetPerimeter());
figure.ShowInfo();
Console.WriteLine();

// Задание 4
IPrinter applicant1 = new Applicant()
{
    FullName = "Михалков Иван Иванович",
    ClassNumber = 9,
    AverageScore = 4.50
};

IPrinter rectangle1 = new Rectangle()
{
    Height = 10,
    Width = 2
};

applicant1.Print();
rectangle1.Print();
Console.WriteLine();

IPrinter[] printerArray = [
    applicant1,
    new Applicant()
    {
        FullName = "Тестов Тест Тесторович",
        ClassNumber = 11,
        AverageScore = 4.77
    },
    rectangle1,
    new Rectangle()
    {
        Height = 8,
        Width = 5
    }];

foreach (var item in printerArray)
{
    if (item is IFigure Ifigure)
        Console.WriteLine(Ifigure.Name);

    item.Print();
}
