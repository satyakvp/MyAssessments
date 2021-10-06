using FluentAssertions;
using Xunit;

namespace OrderProcessing.BusinessRuleEngine.ConsoleApp.UnitTests
{
    public class ShippingRuleStrategyTests
    { 
        private ShippingRuleStrategy strategy;

        public ShippingRuleStrategyTests()
        {
            this.strategy = new ShippingRuleStrategy();
        }

        [Theory]
        [InlineData(PaymentType.Physical, true)]
        [InlineData(PaymentType.Book, false)]
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
