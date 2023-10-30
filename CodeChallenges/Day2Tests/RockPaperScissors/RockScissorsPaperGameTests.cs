using Day02.RockPaperScissors;

namespace Day02Tests.RockPaperScissors
{
    [TestClass]
    public class RockScissorsPaperGameTests
    {
        [DataRow(0, 0)]
        [DataRow(1, 1)]
        [DataRow(1028, 1028)]
        [DataRow(-5,-5)]
        [TestMethod]
        public void LosingRound_Adds_0_To_ShapeScore(int shapeScore, int expectedScore)
        {
            // arrange
            var rockPaperScissorsGame = new RockPaperScissorsGame();    
            var myShape = new Shape(shapeScore, "Loosing");
            var opponentShape = new Shape(shapeScore, "Winning");
                opponentShape.Beats(myShape);

            // act
            var totalScore = rockPaperScissorsGame.CalculateMyTotalScore(new List<(Shape, Shape)> { (opponentShape, myShape) });

            // assert
            Assert.AreEqual(expectedScore, totalScore);
        }

        [DataRow(0, 6)]
        [DataRow(42, 48)]
        [DataRow(-925, -919)]
        [TestMethod]
        public void WinningRound_Adds_6_To_ShapeScore(int shapeScore, int expectedScore)
        {
            // arrange
            var rockPaperScissorsGame = new RockPaperScissorsGame();
            var opponentShape = new Shape(shapeScore, "Losing");
            var myShape = new Shape(shapeScore, "Winning");
                myShape.Beats(opponentShape);    

            // act
            var totalScore = rockPaperScissorsGame.CalculateMyTotalScore(new List<(Shape, Shape)> { (opponentShape, myShape) });

            // assert
            Assert.AreEqual(expectedScore, totalScore);
        }

        [DataRow(0, 3)]
        [DataRow(99, 102)]
        [DataRow(-123, -120)]
        [TestMethod]
        public void DrawRound_Adds_3_To_ShapeScore(int shapeScore, int expectedScore)
        {
            // arrange
            var rockPaperScissorsGame = new RockPaperScissorsGame();
            var shape = new Shape(shapeScore, "Draw");

            // act
            var totalScore = rockPaperScissorsGame.CalculateMyTotalScore(new List<(Shape, Shape)> { (shape, shape) });

            // assert
            Assert.AreEqual(expectedScore, totalScore);
        }

        [TestMethod]
        public void Calculate_sums_the_calculatedScores()
        {
            // arrange
            var rockPaperScissorsGame = new RockPaperScissorsGame();
            var myShape = new Shape(1, "Loosing");
            var opponentShape = new Shape(1, "Winning");
                opponentShape.Beats(myShape);

            // act
            var totalScore = rockPaperScissorsGame.CalculateMyTotalScore(new List<(Shape, Shape)> { 
                (opponentShape, myShape), 
                (opponentShape, myShape), 
                (opponentShape, myShape), 
                (opponentShape, myShape), 
            });

            // assert
            Assert.AreEqual(4, totalScore);
        }
    }
}
