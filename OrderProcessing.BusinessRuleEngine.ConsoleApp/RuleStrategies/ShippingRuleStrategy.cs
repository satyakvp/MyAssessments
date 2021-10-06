using OrderProcessing.BusinessRuleEngine.ConsoleApp.Constants;
using OrderProcessing.BusinessRuleEngine.ConsoleApp.RuleStrategies.Definitions;

namespace OrderProcessing.BusinessRuleEngine.ConsoleApp
{
    public class ShippingRuleStrategy : BusinessRuleStrategyBase
    {
        public override bool IsMatch(PaymentType type)
        {
            return type == PaymentType.Physical;
        }

        public override string HandleOrder()
        {
            return StrategyConstants.ShippingRuleText;
        }

    }
}