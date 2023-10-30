using System.Numerics;

namespace Day25.NumberConversion
{
    public class SnafuToNumberConvertor
    {
        public BigInteger Convert(string snafu)
        {
            var snafuSequence = snafu.AsSpan().Trim();
            BigInteger result = 0;
            for (int i = snafuSequence.Length - 1; i >= 0; i--)
            {
                var snafuDigit = snafuSequence[snafuSequence.Length - 1 - i];
                var number = FromChar(snafuDigit);
                result += number * (BigInteger)Math.Pow(Snafu.ValuesPerDigit, i);
            }
            return result;
        }

        public int FromChar(char value)
        {
            switch (value)
            {
                case '=': return -2;
                case '-': return -1;
                case '0': return 0;
                case '1': return 1;
                case '2': return 2;

                default:
                    throw new ArgumentOutOfRangeException($"{nameof(value)} = {value}, range = -2...+2");
            }
        }

    }
}
