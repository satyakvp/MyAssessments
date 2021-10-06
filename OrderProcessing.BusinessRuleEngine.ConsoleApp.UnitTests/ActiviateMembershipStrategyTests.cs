using FluentAssertions;
using Xunit;

namespace OrderProcessing.BusinessRuleEngine.ConsoleApp.UnitTests
{
    public class ActiviateMembershipStrategyTests
    {
        private ActiviateMembershipStrategy strategy;

        public ActiviateMembershipStrategyTests()
        {
            this.strategy = new ActiviateMembershipStrategy();
        }

        [Theory]
        [InlineData(PaymentType.ActivateMembership, true)]
        [InlineData(PaymentType.UpgradeMembership, false)]
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


