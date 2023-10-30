using Day02.RockPaperScissors;

namespace Day02.Decription
{
    public class ImprovedStrategyGuideDecryptor : StrategyGuideDecryptor
    {
        ShapeCollection Shapes = ShapeCollection.Create();

        protected override (Shape opponentShape, Shape myShape) DecriptRound(string encryptedStrategy)
        {
            var shapeStrategies = encryptedStrategy.Trim().Split(' ');
            var opponentShape = SelectOpponentShape(shapeStrategies[0]);
            var myShape = SelectMyShape(opponentShape, shapeStrategies[1]);
            return (opponentShape, myShape);
        }

        private Shape SelectOpponentShape(string encryptedStrategy)
        {
            switch (encryptedStrategy)
            {
                case "A": return Shapes.Rock;
                case "B": return Shapes.Paper;
                case "C": return Shapes.Scissors;
            }
            throw new Exception($"Kon '{encryptedStrategy}' niet ontcijferen.");
        }

        private Shape SelectMyShape(Shape opponentShape, string encryptedStrategy)
        {
            switch (encryptedStrategy)
            {
                case "X": return opponentShape.WinsFrom;
                case "Y": return opponentShape;
                case "Z": return opponentShape.LosesFrom;
            }
            throw new Exception($"Kon '{encryptedStrategy}' niet ontcijferen.");
        }
    }
}
