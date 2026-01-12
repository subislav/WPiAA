using System;

namespace Decorator
{
    public abstract class PaymentDecorator : IPayment
    {
        protected IPayment _payment;
        public PaymentDecorator(IPayment payment)
        {
            _payment = payment;
        }
        public virtual void Pay(double amount)
        {
            _payment.Pay(amount);
        }
    }
    public class SmsNotificationDecorator : PaymentDecorator
    {
        public SmsNotificationDecorator(IPayment payment) : base(payment) { }

        public override void Pay(double amount)
        {
            base.Pay(amount);
            SendSms();
        }
        private void SendSms()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("SMS: Twoje zamówienie zostało opłacone.");
            Console.ResetColor();
        }
    }
    public class LoyaltyPointsDecorator : PaymentDecorator
    {
        public LoyaltyPointsDecorator(IPayment payment) : base(payment) { }

        public override void Pay(double amount)
        {
            base.Pay(amount);
            AddPoints(amount);
        }
        private void AddPoints(double amount)
        {
            int points = (int)amount / 10;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Dodano {points} punktów lojalnościowych do Twojego konta.");
            Console.ResetColor();
        }
    }
    public class PageRedirectDecorator : PaymentDecorator
    {
        public PageRedirectDecorator(IPayment payment) : base(payment) { }

        public override void Pay(double amount)
        {
            base.Pay(amount);
            Redirect();
        }
        private void Redirect()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Przekierowanie na stronę główną sklepu... Dziękujemy za zakupy.");
            Console.ResetColor();
        }
    }
}