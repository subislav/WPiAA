using System;

namespace Decorator
{
    public class Shop
    {
        public void ProcessOrder(double amount)
        {
            Console.WriteLine($"Do zapłaty: {amount} PLN");
            Console.WriteLine("Wybierz metodę płatności:");
            Console.WriteLine("1. Przelew tradycyjny");
            Console.WriteLine("2. BLIK");
            Console.WriteLine("3. Karta Płatnicza");
            string choice = Console.ReadLine();
            IPayment paymentProcess;
            paymentProcess = new BasePayment();
            if (choice == "3")
            {
                paymentProcess = new SmsNotificationDecorator(paymentProcess);
                paymentProcess = new LoyaltyPointsDecorator(paymentProcess);
                paymentProcess = new PageRedirectDecorator(paymentProcess);
            }
            else
            {
                Console.WriteLine("Płatność standardowa.");
            }
            Console.WriteLine();
            paymentProcess.Pay(amount);
        }
    }
}