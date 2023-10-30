namespace Day02.RockPaperScissors
{
    public class ShapeCollection
    {
        public readonly Shape Rock;
        public readonly Shape Paper;
        public readonly Shape Scissors;
        public const string RockShapeName = "Rock";
        public const string PaperShapeName = "Paper";
        public const string ScissorsShapeName = "Scissors";

        const int _RockShapeScore = 1;
        const int _PaperShapeScore = 2;
        const int _ScissorsShapeScore = 3;

        private ShapeCollection(Shape rock, Shape paper, Shape scissors) 
        { 
            Rock = rock;
            Paper = paper;
            Scissors = scissors;
        }

        public static ShapeCollection Create()
        {
            var rock = new Shape(_RockShapeScore, RockShapeName);
            var paper = new Shape(_PaperShapeScore, PaperShapeName);
            var scissors = new Shape(_ScissorsShapeScore, ScissorsShapeName);
            rock.Beats(scissors);
            paper.Beats(rock);
            scissors.Beats(paper);
            return new ShapeCollection(rock, paper, scissors);
        }
    }

}
