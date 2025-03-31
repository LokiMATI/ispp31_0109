namespace Task1
{
    public class Context
    {
        private IStrategy _strategy;

        public Context(IStrategy strategy)
            => _strategy = strategy;

        public int ExecuteStrategy(int num1, int num2)
            => _strategy.DoOperation(num1, num2);
    }
}