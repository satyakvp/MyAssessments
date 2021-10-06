namespace OrderProcessing.BusinessRuleEngine.ConsoleApp
{
    public class CommissionPaymentRuleStrategy
    {
        public bool IsMatch(PaymentType type)
        {
            return type == PaymentType.PhysicalOrBook;
        }
    }
}