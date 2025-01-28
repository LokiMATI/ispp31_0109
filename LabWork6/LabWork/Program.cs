using LabWork;

class Program
{
    static void Main()
    {
        // Задание 1
        Applicant applicant1 = new Applicant();
        Applicant applicant2 = new Applicant("Матигоров Никита Иванович", 9, 4.44);

        // Задание 2
        Console.WriteLine(applicant2[2]);
        Console.WriteLine(applicant2[-1]);
        Console.WriteLine(applicant1["ФИО"]);

        // Задание 3
        Console.WriteLine(GetPerimeter(1));
        Console.WriteLine(GetPerimeter(1, 2));

        // Задание 4
        Console.WriteLine(GetDegree(2, 3));
        Console.WriteLine(GetDegree(2));
        
    }

    static int GetPerimeter(int side) =>
        side * 4;

    static int GetPerimeter(int height, int width) =>
        2 * (height + width);

    static int GetDegree(int x, int n)
    {
        if (n < 0)
            return -1;

        int result = 1;

        for (int i = n; i > 0; i--)
            result *= x;
        
        return result;
    }

    static int GetDegree(int x) =>
        x * x;
}