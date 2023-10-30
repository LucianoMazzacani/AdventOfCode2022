using Day02.RockPaperScissors;

namespace Day02.Decription
{
    public class InitialStrategyGuideDecryptor : StrategyGuideDecryptor
    {
        ShapeCollection Shapes = ShapeCollection.Create();

        protected override (Shape opponentShape, Shape myShape) DecriptRound(string encryptedStrategy)
        {
            var shapes = encryptedStrategy.Trim().Split(' ');
            var opponentShape = SelectShape(shapes[0]);
            var myShape = SelectShape(shapes[1]);
            return (opponentShape, myShape);
        }

        private Shape SelectShape(string v)
        {
            switch (v)
            {
                case "A": return Shapes.Rock;
                case "B": return Shapes.Paper;
                case "C": return Shapes.Scissors;

                case "X": return Shapes.Rock;
                case "Y": return Shapes.Paper;
                case "Z": return Shapes.Scissors;
            }
            throw new Exception($"Kon '{v}' niet ontcijferen.");
        }
    }
}
