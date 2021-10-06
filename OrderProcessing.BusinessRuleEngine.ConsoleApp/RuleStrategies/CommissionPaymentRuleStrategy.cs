using OrderProcessing.BusinessRuleEngine.ConsoleApp.Constants;
using OrderProcessing.BusinessRuleEngine.ConsoleApp.RuleStrategies.Definitions;

namespace OrderProcessing.BusinessRuleEngine.ConsoleApp
{
    public class CommissionPaymentRuleStrategy : BusinessRuleStrategyBase
    {
        public override bool IsMatch(PaymentType type)
        {
            return type == PaymentType.PhysicalOrBook;
        }

        public override string HandleOrder()
        {
            return StrategyConstants.CommissionPaymentRuleText;
        }

    }
}