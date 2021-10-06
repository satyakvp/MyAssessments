namespace OrderProcessing.BusinessRuleEngine.ConsoleApp.UnitTests
{
    public class UpgradeMembershipStrategy
    {
        public bool IsMatch(PaymentType type)
        {
            return type == PaymentType.UpgradeMembership;
        }
    }
}