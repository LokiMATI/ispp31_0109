namespace Task1
{
    public class OperationSubstract : IStrategy
    {
        public int DoOperation(int num1, int num2)
            => num1 - num2;
    }
}