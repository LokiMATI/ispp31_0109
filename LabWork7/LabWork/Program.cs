namespace LabWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Applicant applicant = new Applicant() { FullName = "Матигоров Никита Иванович", ClassNumber = 9, AverageScore = 3.44 };


            // Задание 1
            applicant.Print();
            applicant++;
            applicant.Print();
            Console.WriteLine();

            // Задание 2
            Applicant applicant1 = new Applicant();
            applicant1.FullName = "Тестов Тест Тесторович";
            applicant1.ClassNumber = 9;
            applicant1.AverageScore = 3.24;
            applicant1.Print();
            Applicant applicant2 = new Applicant();
            applicant2.FullName = "Иванов Иван Иванович";
            applicant2.ClassNumber = 11;
            applicant2.AverageScore = 1.32;
            applicant2.Print();

            Applicant applicant3 = applicant1 + applicant2;
            applicant3.Print();
            Console.WriteLine();

            // Задание 3
            applicant3.AverageScore = applicant1.AverageScore;
            applicant3.Print();
            applicant2.Print();
            applicant1.Print();
            Console.WriteLine($"Сравнение Тестов Тест Тесторович(applicant1) и Иванов Иван Иванович(applicant2): {applicant1 == applicant2}");
            Console.WriteLine($"Сравнение Тестов Тест Тесторович(applicant1) и Тестов Тест Тесторович(applicant3): {applicant1 == applicant3}\n");

            // Задание 4
            applicant2.AverageScore = -1;

            applicant2.Print();
            applicant1.Print();

            if (applicant1)
                Console.WriteLine(true);

            if (!applicant1)
                Console.WriteLine(true);
        }
    }
}
