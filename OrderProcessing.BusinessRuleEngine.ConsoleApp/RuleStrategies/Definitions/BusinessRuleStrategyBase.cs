namespace OrderProcessing.BusinessRuleEngine.ConsoleApp.RuleStrategies.Definitions
{
    /// <summary>
    /// BusinessRuleStrategyBase which holds common behaviour which can inherited 
    /// into all the respective strategies.
    /// </summary>
    public abstract class BusinessRuleStrategyBase : IBusinessRuleStrategy
    {
        public abstract bool IsMatch(PaymentType type);

        public abstract string HandleOrder();
    }
}
