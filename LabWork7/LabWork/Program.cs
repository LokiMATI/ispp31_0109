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

        }
    }
}
