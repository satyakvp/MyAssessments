using OrderProcessing.BusinessRuleEngine.ConsoleApp.Constants;
using OrderProcessing.BusinessRuleEngine.ConsoleApp.RuleStrategies.Definitions;

namespace OrderProcessing.BusinessRuleEngine.ConsoleApp
{
    public class FreeVideoShippingRuleStrategy : BusinessRuleStrategyBase
    {
        public override bool IsMatch(PaymentType type)
        {
            return type == PaymentType.LearningToSkiVideo;
        }

        public override string HandleOrder()
        {
            return StrategyConstants.FreeVideoShippingText;
        }

    }
}