using Xunit;

namespace OrderProcessing.BusinessRuleEngine.ConsoleApp.UnitTests
{
    public class UpgradeMembershipStrategyTests
    {
        private UpgradeMembershipStrategy strategy;

        public UpgradeMembershipStrategyTests()
        {
            this.strategy = new UpgradeMembershipStrategy();
        }

        [Theory]
        [InlineData(PaymentType.UpgradeMembership, true)]
        [InlineData(PaymentType.ActivateMembership, false)]
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
