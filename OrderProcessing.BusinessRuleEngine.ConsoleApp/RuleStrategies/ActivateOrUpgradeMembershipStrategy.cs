namespace OrderProcessing.BusinessRuleEngine.ConsoleApp
{
    public class ActivateOrUpgradeMembershipStrategy
    {
        public bool IsMatch(PaymentType type)
        {
            return type == PaymentType.ActivateOrUpgradeMembership;
        }
    }
}