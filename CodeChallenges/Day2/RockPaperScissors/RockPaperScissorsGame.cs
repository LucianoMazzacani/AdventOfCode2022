namespace Day02.RockPaperScissors
{
    public class RockPaperScissorsGame
    {
        private const int _WinningScore = 6;
        private const int _DrawingScore = 3;
        private const int _LosingScore = 0;

        public int CalculateMyTotalScore(IEnumerable<(Shape opponentShape, Shape myShape)> rounds)
        {
            var outcomes = rounds.Select(round => GetOutcome(round));
            var totalScore = outcomes.Sum();
            return totalScore;
        }

        private int GetOutcome((Shape opponentShape, Shape myShape) round)
        {
            var myShape = round.myShape;
            var opponentShape = round.opponentShape;
            var outcome = myShape.Score;

            if (myShape.Equals(opponentShape.LosesFrom))
                return outcome + _WinningScore;

            if (myShape.Equals(opponentShape.WinsFrom))
                return outcome + _LosingScore;

            return outcome + _DrawingScore;
        }
    }
}
