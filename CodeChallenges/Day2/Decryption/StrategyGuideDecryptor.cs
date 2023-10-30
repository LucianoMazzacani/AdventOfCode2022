using Day02.RockPaperScissors;

namespace Day02.Decription
{
    public abstract class StrategyGuideDecryptor
    {
        public IEnumerable<(Shape opponentShape, Shape myShape)> Decrypt(IEnumerable<string> encryptedStrategy) 
        {
            return encryptedStrategy.Select(x => DecriptRound(x));
        }
        protected abstract (Shape opponentShape, Shape myShape) DecriptRound(string encryptedRound);
    }
}
