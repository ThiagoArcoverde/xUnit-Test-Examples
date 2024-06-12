using Xunit;

namespace xUnitExample
{
    public class CalculatorTests
    {

        private readonly Calculator _calculator;

        public CalculatorTests()
        {
            _calculator = new Calculator();
        }

        [Theory]
        [InlineData(5,5,10)]
        [InlineData(0, 0, 0)]
        [InlineData(-5, -5, -10)]
        [InlineData(-5, 5, 0)]
        [InlineData(2, 3, 5)]
        public void SumTest(int num1, int num2, int expected)
        {
            var result = _calculator.Sum(num1, num2);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void SubTest()
        {
            Assert.Equal(0, _calculator.Sub(5, 5));
        }

    }
}
