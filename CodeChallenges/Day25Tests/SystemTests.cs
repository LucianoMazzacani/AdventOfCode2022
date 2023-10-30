using Day25.NumberConversion;
using Day25.Extensions;
using TextReaders;

namespace Day25Tests
{
    [TestClass]
    public class SystemTests
    {
        [DataRow(@"Data\ExampleFuelRequirements.txt", "2=-1=0")]
        [TestMethod]
        public void TestCalculateAmountOf_snafu(string datafile, string expectedResult)
        {
            // arrange
            var fuelRequirementsReader = new TextFileReader { Source = datafile };
            var numberToSnafuConvertor = new NumberToSnafuConvertor();
            var snafuToNumberConvertor = new SnafuToNumberConvertor();

            var fuelNeeded = fuelRequirementsReader
                .ReadAllLines()
                .Select(snafuNumber => snafuToNumberConvertor.Convert(snafuNumber))
                .Sum();

            var result = numberToSnafuConvertor.Convert(fuelNeeded);

            // assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}