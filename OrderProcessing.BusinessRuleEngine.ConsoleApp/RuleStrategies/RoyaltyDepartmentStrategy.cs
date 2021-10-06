using OrderProcessing.BusinessRuleEngine.ConsoleApp.Constants;
using OrderProcessing.BusinessRuleEngine.ConsoleApp.RuleStrategies.Definitions;

namespace OrderProcessing.BusinessRuleEngine.ConsoleApp
{
    public class RoyaltyDepartmentStrategy : BusinessRuleStrategyBase
    {
        public override bool IsMatch(PaymentType type)
        {
            return type == PaymentType.Book;
        }

        public override string HandleOrder()
        {
            return StrategyConstants.RoyaltyDepartmentText;
        }
    }
}