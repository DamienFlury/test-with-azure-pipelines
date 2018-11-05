
using Xunit;

namespace TestWithAzurePipelines.Main.Tests
{
    public class IntExtensionTest
    {
        [Theory]
        [InlineData(1, false)]
        [InlineData(2, true)]
        [InlineData(3, false)]
        [InlineData(4, true)]
        [InlineData(23, false)]
        [InlineData(64, true)]
        public void IsEvenTest(int number, bool expected)
        {
            Assert.Equal(number.IsEven(), expected);
        }

        [Theory]
        [InlineData(1, true)]
        [InlineData(-2, false)]
        [InlineData(15, true)]
        [InlineData(44, false)]
        [InlineData(43, true)]
        [InlineData(2435, true)]
        public void IsOddTest(int number, bool expected)
        {
            Assert.Equal(number.IsOdd(), expected);
        }

        [Theory]
        [InlineData(1, false)]
        [InlineData(2, true)]
        [InlineData(3, true)]
        [InlineData(200, false)]
        [InlineData(23, true)]
        [InlineData(5, true)]
        public void IsPrimeTest(int number, bool expected)
        {
            Assert.Equal(number.IsPrime(), expected);
        }
    }

}