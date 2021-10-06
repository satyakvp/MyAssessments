namespace OrderProcessing.BusinessRuleEngine.ConsoleApp.RuleStrategies.Definitions
{
    public interface IBusinessRuleStrategy
    {
        bool IsMatch(PaymentType type);

        string HandleOrder();
    }
}
