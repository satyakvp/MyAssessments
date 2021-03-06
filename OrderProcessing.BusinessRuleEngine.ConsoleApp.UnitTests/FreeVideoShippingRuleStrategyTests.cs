using FluentAssertions;
using Xunit;

namespace OrderProcessing.BusinessRuleEngine.ConsoleApp.UnitTests
{
    public class FreeVideoShippingRuleStrategyTests
    {
        private FreeVideoShippingRuleStrategy strategy;

        public FreeVideoShippingRuleStrategyTests()
        {
            this.strategy = new FreeVideoShippingRuleStrategy();
        }

        [Theory]
        [InlineData(PaymentType.LearningToSkiVideo, true)]
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
