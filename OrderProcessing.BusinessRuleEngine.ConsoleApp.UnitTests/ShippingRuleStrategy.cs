using System;

namespace OrderProcessing.BusinessRuleEngine.ConsoleApp.UnitTests
{
    public class ShippingRuleStrategy
    {
        public bool IsMatch(PaymentType type)
        {
            return type == PaymentType.Physical;
        }
    }
}