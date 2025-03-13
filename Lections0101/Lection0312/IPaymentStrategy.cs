using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lection0312
{
    public interface IPaymentStrategy
    {
        void Pay(int cost);
    }

    public class CreditPayment : IPaymentStrategy
    {
        public void Pay(int cost)
            => Console.WriteLine("pay by credit");
    }

    public class CardPayment : IPaymentStrategy
    {
        public void Pay(int cost)
            => Console.WriteLine("pay by card");
    }
}