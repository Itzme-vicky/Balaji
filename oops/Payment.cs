using System;
using System.Collections.Generic;
using System.Text;

namespace oops
{
    abstract class Payment
    {
        // Common properties for all payment types
        public void ValidatePayment()
        {
            Console.WriteLine("Payment Validated");
        }
        public abstract void ProcessPayment(decimal amount);
        public abstract void GenerateReceipt();
    }

    class CreditCardPayment : Payment
    {
        public override void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing credit card payment of {amount:C}");
        }
        public override void GenerateReceipt()
        {
            Console.WriteLine("Generating credit card payment receipt");
        }
    }

    class debitCardPayment : Payment
    {
        public override void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing debit card payment of {amount:C}");
        }
        public override void GenerateReceipt()
        {
            Console.WriteLine("Generating debit card payment receipt");
        }
    }

    class upiPayment : Payment
    {
        public override void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing UPI payment of {amount:C}");
        }
        public override void GenerateReceipt()
        {
            Console.WriteLine("Generating UPI payment receipt");
        }
    }

    class netBankingPayment : Payment
    {
        public override void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing net banking payment of {amount:C}");
        }
        public override void GenerateReceipt()
        {
            Console.WriteLine("Generating net banking payment receipt");
        }
    }

     class PaymentService
    {
        public void MakePayment(Payment payment, decimal amount)
        {
            payment.ValidatePayment();
            payment.ProcessPayment(amount);
            payment.GenerateReceipt();
        }
    }
}
