using Day02.Decription;
using Day02.RockPaperScissors;
using TextReaders;

namespace Day2Tests
{
    [TestClass]
    public class SystemTests
    {

        [TestMethod]
        public void InitialStrategy_results_in_15()
        {
            // arrange
            var encryptedStrategyGuideReader = new TextFileReader { Source = @"Data\ExampleData.txt" };
            var strategyGuideDecryptor = new InitialStrategyGuideDecryptor();
            var game = new RockPaperScissorsGame();

            // act
            var encryptedStrategyGuide = encryptedStrategyGuideReader.ReadAllLines();
            var strategyGuide = strategyGuideDecryptor.Decrypt(encryptedStrategyGuide);
            var result = game.CalculateMyTotalScore(strategyGuide);

            // assert
            Assert.AreEqual(15,result);
        }

        [TestMethod]
        public void ImprovedStrategy_results_in_12()
        {
            // arrange
            var encryptedStrategyGuideReader = new TextFileReader { Source = @"Data\ExampleData.txt" };
            var strategyGuideDecryptor = new ImprovedStrategyGuideDecryptor();
            var game = new RockPaperScissorsGame();

            // act
            var encryptedStrategyGuide = encryptedStrategyGuideReader.ReadAllLines();
            var strategyGuide = strategyGuideDecryptor.Decrypt(encryptedStrategyGuide);
            var result = game.CalculateMyTotalScore(strategyGuide);

            // assert
            Assert.AreEqual(12, result);
        }

    }
}