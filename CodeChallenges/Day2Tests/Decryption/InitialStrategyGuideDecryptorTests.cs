using Day02.Decription;
using Day02.RockPaperScissors;

namespace Day02Tests.Decryption
{
    [TestClass]
    public class InitialStrategyGuideDecryptorTests
    {

        [DataRow("A X", ShapeCollection.RockShapeName, ShapeCollection.RockShapeName)]
        [DataRow("B X", ShapeCollection.PaperShapeName, ShapeCollection.RockShapeName)]
        [DataRow("C X", ShapeCollection.ScissorsShapeName, ShapeCollection.RockShapeName)]
        [DataRow("A Y", ShapeCollection.RockShapeName, ShapeCollection.PaperShapeName)]
        [DataRow("B Y", ShapeCollection.PaperShapeName, ShapeCollection.PaperShapeName)]
        [DataRow("C Y", ShapeCollection.ScissorsShapeName, ShapeCollection.PaperShapeName)]
        [DataRow("A Z", ShapeCollection.RockShapeName, ShapeCollection.ScissorsShapeName)]
        [DataRow("B Z", ShapeCollection.PaperShapeName, ShapeCollection.ScissorsShapeName)]
        [DataRow("C Z", ShapeCollection.ScissorsShapeName, ShapeCollection.ScissorsShapeName)]
        [TestMethod]
        public void Decrypt_returns_correct_Shapes(string encryptedStrategyLine, string opponentShapeName, string myShapeName)
        {
            // arrange
            var encryptedStrategyGuide = new List<string> { encryptedStrategyLine };
            var decryptor = new InitialStrategyGuideDecryptor();

            // act
            var rounds = decryptor.Decrypt(encryptedStrategyGuide);
            var round = rounds.First();

            // assert
            Assert.AreEqual(opponentShapeName, round.opponentShape.Name);
            Assert.AreEqual(myShapeName, round.myShape.Name);  
        }
    }
}
