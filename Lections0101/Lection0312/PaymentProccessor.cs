namespace Lection0312
{
    public class PaymentProccessor
    {
        private IPaymentStrategy _strategy;

        

        public void ProccessPayment(int cost)
            => _strategy?.Pay(cost); // Вызов алгоритма

        public void ChangeStrategy(IPaymentStrategy strategy)
            => _strategy = strategy;

        // Гадость! Не писать!
        public IPaymentStrategy IPaymentStrategy
        {
            get => default;
            set
            {
            }
        }
    }
}