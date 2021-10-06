namespace OrderProcessing.BusinessRuleEngine.ConsoleApp
{
    public class ShippingRuleStrategy
    {
        public bool IsMatch(PaymentType type)
        {
            return type == PaymentType.Physical;
        }
    }
}