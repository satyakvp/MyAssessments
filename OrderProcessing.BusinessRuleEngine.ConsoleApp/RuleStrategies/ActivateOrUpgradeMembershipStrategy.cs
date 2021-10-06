using OrderProcessing.BusinessRuleEngine.ConsoleApp.Constants;
using OrderProcessing.BusinessRuleEngine.ConsoleApp.RuleStrategies.Definitions;

namespace OrderProcessing.BusinessRuleEngine.ConsoleApp
{
    public class ActivateOrUpgradeMembershipStrategy : BusinessRuleStrategyBase
    {
        public override bool IsMatch(PaymentType type)
        {
            return type == PaymentType.ActivateOrUpgradeMembership;
        }

        public override string HandleOrder()
        {
            return StrategyConstants.ActivateOrUpgradeMembershipText;
        }
    }
}