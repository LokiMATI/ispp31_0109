using LabWork;

class Program
{
    static void Main()
    {
        // Задание 1
        Applicant applicant1 = new Applicant();
        Applicant applicant2 = new Applicant("Матигоров Никита Иванович", 9, 4.44);

        // Задание 2
        Console.WriteLine("Задание 2");
        Console.WriteLine(applicant2[2]);
        Console.WriteLine(applicant2[-1]);
        Console.WriteLine(applicant1["ФИО"]);
        Console.WriteLine(applicant1["Пример"]);

        // Задание 3
        Console.WriteLine("\nЗадание 3");
        Console.WriteLine(GetPerimeter(1));
        Console.WriteLine(GetPerimeter(1, 2));

        // Задание 4
        Console.WriteLine("\nЗадание 4");
        Console.WriteLine(Exponentiation(2, 3));
        Console.WriteLine(Exponentiation(2));
        
    }

    // Задание 3
    static int GetPerimeter(int side) =>
        side * 4;

    static int GetPerimeter(int height, int width) =>
        2 * (height + width);

    // Задание 4
    static double Exponentiation(double x, int n)
    {
        if (n < 0)
            return -1;

        double result = 1;

        for (; n > 0; n--)
            result *= x;
        
        return result;
    }

    static double Exponentiation(double x) =>
        x * x;
}