﻿namespace OrderProcessing.BusinessRuleEngine.ConsoleApp
{
    public class ActiviateMembershipStrategy
    {
        public bool IsMatch(PaymentType type)
        {
            return type == PaymentType.ActivateMembership;
        }
    }
}