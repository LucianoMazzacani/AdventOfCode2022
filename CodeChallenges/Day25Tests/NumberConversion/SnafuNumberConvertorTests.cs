using Day25;
using Day25.NumberConversion;

namespace Day25Tests.NumberConversion
{
    [TestClass]
    public class SnafuNumberConvertorTests
    {
        // TestSet
        [DataRow("1=-0-2", 1747)]
        [DataRow(" 12111", 906)]
        [DataRow("  2=0=", 198)]
        [DataRow("    21", 11)]
        [DataRow("  2=01", 201)]
        [DataRow("   111", 31)]
        [DataRow(" 20012", 1257)]
        [DataRow("   112", 32)]
        [DataRow(" 1=-1=", 353)]
        [DataRow("  1-12", 107)]
        [DataRow("    12", 7)]
        [DataRow("    1=", 3)]
        [DataRow("   122", 37)]
        [DataRow("=", -2)]
        [DataRow("-", -1)]
        [DataRow("0", 0)]
        [DataRow("1", 1)]
        [DataRow("2", 2)]
        [DataRow("1=", 3)]
        [DataRow("1-", 4)]
        [DataRow("10", 5)]
        [DataRow("11", 6)]
        [DataRow("12", 7)]
        [DataRow("2=", 8)]
        [DataRow("2-", 9)]
        [DataRow("20", 10)]
        [TestMethod]
        public void ToDecimal_converts_SnafuToDecimal(string snafu, int expected)
        {
            // arrange
            var convertor = new SnafuToNumberConvertor();

            // act
            var result = convertor.Convert(snafu);

            // assert
            Assert.AreEqual(expected, result);
        }

        [DataRow(1, "1")]
        [DataRow(2, "2")]
        [DataRow(3, "1=")]
        [DataRow(4, "1-")]
        [DataRow(5, "10")]
        [DataRow(6, "11")]
        [DataRow(7, "12")]
        [DataRow(8, "2=")]
        [DataRow(9, "2-")]
        [DataRow(10, "20")]
        [DataRow(15, "1=0")]
        [DataRow(20, "1-0")]
        [DataRow(29, "11-")]
        [DataRow(2022, "1=11-2")]
        [DataRow(12345, "1-0---0")]
        [DataRow(314159265, "1121-1110-1=0")]
        [TestMethod]
        public void ToSnafu_converts_DecimalToSnafu(int number, string snafu)
        {
            // arrange
            var convertor = new NumberToSnafuConvertor();

            // act 
            var result = convertor.Convert(number);

            // assert
            Assert.AreEqual(snafu, result);
        }
    }
}