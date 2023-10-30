using System.Numerics;

namespace Day25.Extensions
{
    public static class BigIntegerCollectionExtensions
    {
        public static BigInteger Sum(this IEnumerable<BigInteger> numbers)
        {
            BigInteger sum = 0;
            var enummerator = numbers.GetEnumerator();
            while (enummerator.MoveNext())
            {
                sum += enummerator.Current;
            }
            return sum;
        }
    }
}
