using OrderProcessing.BusinessRuleEngine.ConsoleApp.Constants;
using OrderProcessing.BusinessRuleEngine.ConsoleApp.RuleStrategies.Definitions;

namespace OrderProcessing.BusinessRuleEngine.ConsoleApp
{
    public class UpgradeMembershipStrategy : BusinessRuleStrategyBase
    {
        public override bool IsMatch(PaymentType type)
        {
            return type == PaymentType.UpgradeMembership;
        }

        public override string HandleOrder()
        {
            return StrategyConstants.UpgradeMemershipText;
        }

    }
}