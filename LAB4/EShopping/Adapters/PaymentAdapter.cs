using System;

namespace EShopping.Adapters
{
    public class PaymentAdapter
    {
        public bool Pay(string cardType, string cardNumber, decimal amount, out string reference)
        {
            reference = "PAY-" + DateTime.Now.ToString("yyyyMMddHHmmss");
            return !string.IsNullOrWhiteSpace(cardNumber) && amount > 0;
        }
    }
}
