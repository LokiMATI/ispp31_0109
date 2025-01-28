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


        }
    }
}
