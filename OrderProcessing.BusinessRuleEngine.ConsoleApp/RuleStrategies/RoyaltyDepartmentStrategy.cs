namespace OrderProcessing.BusinessRuleEngine.ConsoleApp
{
    public class RoyaltyDepartmentStrategy
    {
        public bool IsMatch(PaymentType type)
        {
            return type == PaymentType.Book;
        }
    }
}