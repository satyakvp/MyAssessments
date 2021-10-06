using FluentAssertions;
using Xunit;

namespace OrderProcessing.BusinessRuleEngine.ConsoleApp.UnitTests
{
    public class RoyaltyDepartmentStrategyTests
    { 
        private readonly RoyaltyDepartmentStrategy strategy;

        public RoyaltyDepartmentStrategyTests()
        {
            this.strategy = new RoyaltyDepartmentStrategy();
        }

        [Theory]
        [InlineData(PaymentType.Book, true)]
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
