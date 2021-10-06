namespace OrderProcessing.BusinessRuleEngine.ConsoleApp
{
    public class UpgradeMembershipStrategy
    {
        public bool IsMatch(PaymentType type)
        {
            return type == PaymentType.UpgradeMembership;
        }
    }
}