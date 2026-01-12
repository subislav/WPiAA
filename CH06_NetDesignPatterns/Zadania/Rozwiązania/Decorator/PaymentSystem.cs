using System;

namespace Decorator
{
    public interface IPayment
    {
        void Pay(double amount);
    }
    public class BasePayment : IPayment
    {
        public void Pay(double amount)
        {
            Console.WriteLine($"Pobrano z konta kwotę: {amount} PLN.");
        }
    }
}