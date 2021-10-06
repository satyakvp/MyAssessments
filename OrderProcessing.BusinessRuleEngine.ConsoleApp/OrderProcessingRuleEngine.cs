using OrderProcessing.BusinessRuleEngine.ConsoleApp.Factory;

namespace OrderProcessing.BusinessRuleEngine.ConsoleApp
{
    public class OrderProcessingRuleEngine
    {
        private readonly BusinessRuleStrategyRegistry businessRuleStrategyRegistry;

        public OrderProcessingRuleEngine(BusinessRuleStrategyRegistry businessRuleStrategyRegistry)
        {
            this.businessRuleStrategyRegistry = businessRuleStrategyRegistry;
        }

        public string ProcessPayment(PaymentType productType)
        {
            var businessRuleStrategy = this.businessRuleStrategyRegistry.GetBusinessRuleStrategy(productType);

            return businessRuleStrategy == null
                ? throw new System.Exception("No Strategy found for the unknown product being passed in")
                : businessRuleStrategy.HandleOrder();
        }
    }
}
