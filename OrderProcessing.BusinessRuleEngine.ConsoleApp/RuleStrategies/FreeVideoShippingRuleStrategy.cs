﻿namespace OrderProcessing.BusinessRuleEngine.ConsoleApp
{
    public class FreeVideoShippingRuleStrategy
    {
        public bool IsMatch(PaymentType type)
        {
            return type == PaymentType.LearningToSkiVideo;
        }
    }
}