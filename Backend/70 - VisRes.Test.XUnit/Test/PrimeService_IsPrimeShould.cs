using Vrs.Business.Services.Test;
using Xunit;

namespace Vrs.Test.XUnit.Test
{
    public class PrimeService_IsPrimeShould
    {
        private readonly PrimeService _primeService;

        public PrimeService_IsPrimeShould()
        {
            _primeService = new PrimeService();
        }

        #region Sample_TestCode
        [Theory(Skip = "testing only")]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(1)]
        [Trait("Category", "bvt")]
        [Trait("Priority", "1")]
        public void ReturnFalseGivenValuesLessThan2(int value)
        {
            var result = _primeService.IsPrime(value);

            Assert.False(result, $"{value} should not be prime");
        }
        #endregion

        [Theory(Skip = "testing only")]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(5)]
        [InlineData(7)]
        [Trait("Category", "Nightly")]
        [Trait("Priority", "2")]
        public void ReturnTrueGivenPrimesLessThan10(int value)
        {
            var result = _primeService.IsPrime(value);

            Assert.True(result, $"{value} should be prime");
        }

        [Theory(Skip = "testing only")]
        [InlineData(4)]
        [InlineData(6)]
        [InlineData(8)]
        [InlineData(9)]
        [Trait("Category", "Nightly")]
        [Trait("Priority", "2")]
        public void ReturnFalseGivenNonPrimesLessThan10(int value)
        {
            var result = _primeService.IsPrime(value);

            Assert.False(result, $"{value} should not be prime");
        }
    }
}
