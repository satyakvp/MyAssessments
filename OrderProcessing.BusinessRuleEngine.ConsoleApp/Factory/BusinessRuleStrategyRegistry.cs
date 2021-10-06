using OrderProcessing.BusinessRuleEngine.ConsoleApp.RuleStrategies.Definitions;
using System.Collections.Generic;
using System.Linq;

namespace OrderProcessing.BusinessRuleEngine.ConsoleApp.Factory
{
    /// <summary>
    /// Strategy pattern applied here. This registry would return
    /// respective strategy when its matched.
    /// ChainOfResponsibitlity Pattern can also be applied here in place of Strategy. 
    /// But I prefer to go for Strategy pattern.
    /// </summary
    public sealed class BusinessRuleStrategyRegistry
    {
        private readonly IEnumerable<IBusinessRuleStrategy> businessRuleStrategies;

        /// <summary>
        /// Dependancy Inversion principle applied
        /// </summary>
        /// <param name="businessRuleStrategies"></param>
        public BusinessRuleStrategyRegistry(IEnumerable<IBusinessRuleStrategy> businessRuleStrategies)
        {
            this.businessRuleStrategies = businessRuleStrategies;
        }

        public IBusinessRuleStrategy GetBusinessRuleStrategy(PaymentType productType)
        {
            return businessRuleStrategies.FirstOrDefault(p => p.IsMatch(productType));
        }

    }
}