using System;

namespace OrderProcessing.BusinessRuleEngine.ConsoleApp.UnitTests
{
    public class ActiviateMembershipStrategy
    {
        public bool IsMatch(PaymentType type)
        {
            return type == PaymentType.ActivateMembership;
        }
    }
}