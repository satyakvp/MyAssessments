using FluentAssertions;
using Xunit;

namespace OrderProcessing.BusinessRuleEngine.ConsoleApp.UnitTests
{
    public class CommissionPaymentRuleStrategyTests
    {
        private CommissionPaymentRuleStrategy strategy;

        public CommissionPaymentRuleStrategyTests()
        {
            this.strategy = new CommissionPaymentRuleStrategy();
        }

        [Theory]
        [InlineData(PaymentType.PhysicalOrBook, true)]
        [InlineData(PaymentType.LearningToSkiVideo, false)]
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
