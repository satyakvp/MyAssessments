using FluentAssertions;
using Xunit;

namespace OrderProcessing.BusinessRuleEngine.ConsoleApp.UnitTests
{
    public class ActivateOrUpgradeMembershipStrategyTests
    {
        private ActivateOrUpgradeMembershipStrategy strategy;

        public ActivateOrUpgradeMembershipStrategyTests()
        {
            this.strategy = new ActivateOrUpgradeMembershipStrategy();
        }

        [Theory]
        [InlineData(PaymentType.ActivateOrUpgradeMembership, true)]
        [InlineData(PaymentType.Physical, false)]
        public void ShouldReturnTrueWhenCorrectProductTypeBeingPassedIn(PaymentType type, bool expected)
        {
            // Arrange

            //Act
            var isMatched = this.strategy.IsMatch(type);

            // Assert
            isMatched.Should().Be(expected);
        }
    }
}
