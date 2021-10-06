using FluentAssertions;
using OrderProcessing.BusinessRuleEngine.ConsoleApp.Constants;
using OrderProcessing.BusinessRuleEngine.ConsoleApp.Factory;
using OrderProcessing.BusinessRuleEngine.ConsoleApp.RuleStrategies.Definitions;
using System.Collections.Generic;
using Xunit;

namespace OrderProcessing.BusinessRuleEngine.ConsoleApp.UnitTests
{
    public class BusinessRuleStrategyRegistryTests
    {
        private BusinessRuleStrategyRegistry businessRuleStrategyRegistry;

        public BusinessRuleStrategyRegistryTests()
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
        }

        [Fact]
        public void ShouldStrategyRegistryReturnCorrectStrategyWhenPaymentForActiveMembership()
        {
            // Arrange

            //Act
            var strategy = this.businessRuleStrategyRegistry.GetBusinessRuleStrategy(PaymentType.ActivateMembership);

            // Assert
            strategy.Should().BeOfType<ActiviateMembershipStrategy>();
            strategy.HandleOrder().Should().Be(StrategyConstants.ActivateMemberText);
        }

        [Fact]
        public void ShouldStrategyRegistryReturnCorrectStrategyWhenPaymentForUpgradeMembership()
        {
            // Arrange

            //Act
            var strategy = this.businessRuleStrategyRegistry.GetBusinessRuleStrategy(PaymentType.UpgradeMembership);

            // Assert
            strategy.Should().BeOfType<UpgradeMembershipStrategy>();
            strategy.HandleOrder().Should().Be(StrategyConstants.UpgradeMemershipText);
        }

        [Fact]
        public void ShouldStrategyRegistryReturnCorrectStrategyWhenPaymentForActiveOrUpgradeMembership()
        {
            // Arrange

            //Act
            var strategy = this.businessRuleStrategyRegistry.GetBusinessRuleStrategy(PaymentType.ActivateOrUpgradeMembership);

            // Assert
            strategy.Should().BeOfType<ActivateOrUpgradeMembershipStrategy>();
            strategy.HandleOrder().Should().Be(StrategyConstants.ActivateOrUpgradeMembershipText);
        }

        [Fact]
        public void ShouldStrategyRegistryReturnCorrectStrategyWhenPaymentForLearningToSkiVideo()
        {
            // Arrange

            //Act
            var strategy = this.businessRuleStrategyRegistry.GetBusinessRuleStrategy(PaymentType.LearningToSkiVideo);

            // Assert
            strategy.Should().BeOfType<FreeVideoShippingRuleStrategy>();
            strategy.HandleOrder().Should().Be(StrategyConstants.FreeVideoShippingText);
        }

        [Fact]
        public void ShouldStrategyRegistryReturnCorrectStrategyWhenPaymentForBook()
        {
            // Arrange

            //Act
            var strategy = this.businessRuleStrategyRegistry.GetBusinessRuleStrategy(PaymentType.Book);

            // Assert
            strategy.Should().BeOfType<RoyaltyDepartmentStrategy>();
            strategy.HandleOrder().Should().Be(StrategyConstants.RoyaltyDepartmentText);
        }

        [Fact]
        public void ShouldStrategyRegistryReturnCorrectStrategyWhenPaymentForPhysical()
        {
            // Arrange

            //Act
            var strategy = this.businessRuleStrategyRegistry.GetBusinessRuleStrategy(PaymentType.Physical);

            // Assert
            strategy.Should().BeOfType<ShippingRuleStrategy>();
            strategy.HandleOrder().Should().Be(StrategyConstants.ShippingRuleText);
        }

        [Fact]
        public void ShouldStrategyRegistryReturnCorrectStrategyWhenPaymentForBookOrPhysical()
        {
            // Arrange

            //Act
            var strategy = this.businessRuleStrategyRegistry.GetBusinessRuleStrategy(PaymentType.PhysicalOrBook);

            // Assert
            strategy.Should().BeOfType<CommissionPaymentRuleStrategy>();
            strategy.HandleOrder().Should().Be(StrategyConstants.CommissionPaymentRuleText);
        }

    }
}
