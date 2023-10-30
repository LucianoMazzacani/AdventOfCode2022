namespace Day02.RockPaperScissors
{ 
    public class Shape
    {
        public readonly int Score;

        public Shape LosesFrom { get; private set; }
        public Shape WinsFrom { get; private set; }

        public void Beats(Shape losingShape) 
        { 
            WinsFrom = losingShape;
            losingShape.LosesFrom = this;
        }
        
        public readonly string Name;
        public override string ToString() => Name;

        public Shape(int shapeScore, string shapeName)
        {
            Score = shapeScore;
            Name = shapeName;
        }
    }
}