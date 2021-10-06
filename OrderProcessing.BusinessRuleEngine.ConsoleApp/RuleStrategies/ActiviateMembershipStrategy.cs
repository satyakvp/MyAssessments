using OrderProcessing.BusinessRuleEngine.ConsoleApp.Constants;
using OrderProcessing.BusinessRuleEngine.ConsoleApp.RuleStrategies.Definitions;

namespace OrderProcessing.BusinessRuleEngine.ConsoleApp
{
    public class ActiviateMembershipStrategy : BusinessRuleStrategyBase
    {
        public override bool IsMatch(PaymentType type)
        {
            return type == PaymentType.ActivateMembership;
        }

        public override string HandleOrder()
        {
            return StrategyConstants.ActivateMemberText;
        }

    }
}