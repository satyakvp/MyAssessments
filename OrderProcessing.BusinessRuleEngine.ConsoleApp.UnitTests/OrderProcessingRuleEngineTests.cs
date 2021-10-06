using FluentAssertions;
using OrderProcessing.BusinessRuleEngine.ConsoleApp.Constants;
using OrderProcessing.BusinessRuleEngine.ConsoleApp.Factory;
using OrderProcessing.BusinessRuleEngine.ConsoleApp.RuleStrategies;
using OrderProcessing.BusinessRuleEngine.ConsoleApp.RuleStrategies.Definitions;
using System;
using System.Collections.Generic;
using Xunit;

namespace OrderProcessing.BusinessRuleEngine.ConsoleApp.UnitTests
{
    public class OrderProcessingRuleEngineTests
    {
        private BusinessRuleStrategyRegistry businessRuleStrategyRegistry;
        private OrderProcessingEngine ruleEngine;

        public OrderProcessingRuleEngineTests()
        {
            // BusinessRuleStrategyRegistry shoud be mocked by using Mocking frameworks like Moq etc.
            this.businessRuleStrategyRegistry = new BusinessRuleStrategyRegistry(
                            new List<IBusinessRuleStrategy>()
                                    {
                                        new ShippingRuleStrategy(),
                                        new RoyaltyDepartmentStrategy(),
                                        new ActiviateMembershipStrategy(),
                                        new UpgradeMembershipStrategy(),
                                        new ActivateOrUpgradeMembershipStrategy(),
                                        new FreeVideoShippingRuleStrategy(),
                                        new CommissionPaymentRuleStrategy()
                                    }
                            );

            this.ruleEngine = new OrderProcessingRuleEngine(this.businessRuleStrategyRegistry);
        }

        [Fact]
        public void ShouldThrowExceptionWhenNoStrategyFound()
        {
            // Arrange

            // Act
            Action result = () => this.ruleEngine.ProcessPayment(PaymentType.Uknown);

            // Assert
            result.Should().ThrowExactly<Exception>()
                .WithMessage("No Strategy found for the unknown product being passed in");

        }


        [Fact]
        public void ShouldFectchCorrectMessageFromRegistryWhenRespectivePaymentTypeBeingPassedIn()
        {
            // Arrange

            // Act
            var strategy = this.ruleEngine.ProcessPayment(PaymentType.ActivateMembership);

            // Assert
            strategy.Should().Be(StrategyConstants.ActivateMemberText);
        }
    }
}
