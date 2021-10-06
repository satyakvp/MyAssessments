using System;

namespace OrderProcessing.BusinessRuleEngine.ConsoleApp.UnitTests
{
    public class FreeVideoShippingRuleStrategy
    {
        public bool IsMatch(PaymentType type)
        {
            return type == PaymentType.LearningToSkiVideo;
        }
    }
}