using Day02.RockPaperScissors;

namespace Day02Tests.RockPaperScissors
{
    [TestClass]
    public class ShapeCollectionTests
    {
        [TestMethod]
        public void Rock_is_correctly_configured()
        {
            // arrange 
            var shapes = ShapeCollection.Create();

            // act
            var rock = shapes.Rock;

            // assert
            Assert.AreEqual(ShapeCollection.RockShapeName, rock.Name);
            Assert.AreEqual(1, rock.Score);
            Assert.AreEqual(shapes.Paper, rock.LosesFrom);
            Assert.AreEqual(shapes.Scissors, rock.WinsFrom);
        }

        [TestMethod]
        public void Paper_is_correctly_configured()
        {
            // arrange 
            var shapes = ShapeCollection.Create();

            // act
            var paper = shapes.Paper;

            // assert
            Assert.AreEqual(ShapeCollection.PaperShapeName, paper.Name);
            Assert.AreEqual(2, paper.Score);
            Assert.AreEqual(shapes.Scissors, paper.LosesFrom);
            Assert.AreEqual(shapes.Rock, paper.WinsFrom);
        }

        [TestMethod]
        public void Scissors_is_correctly_configured()
        {
            // arrange 
            var shapes = ShapeCollection.Create();

            // act
            var scissors = shapes.Scissors;

            // assert
            Assert.AreEqual(ShapeCollection.ScissorsShapeName, scissors.Name);
            Assert.AreEqual(3, scissors.Score);
            Assert.AreEqual(shapes.Rock, scissors.LosesFrom);
            Assert.AreEqual(shapes.Paper, scissors.WinsFrom);
        }

    }
}
