using System.Numerics;

namespace Day25.NumberConversion
{
    public class NumberToSnafuConvertor
    {
        public string Convert(BigInteger number)
        {
            var base5Digits = CreateBase5NumberArray(number);
            var snafuDigits = ConvertBase5DigitsToSnafuDigits(base5Digits);
            return CreateSnafuString(snafuDigits);
        }


        private int[] CreateBase5NumberArray(BigInteger number)
        {
            var remainder = number;
            var digitNr = (int)Math.Floor(BigInteger.Log(remainder, Snafu.ValuesPerDigit));
            // +2 omdat anders de conversie van base5 naar snafu(-2..2) niet goed gaat. (ivm overflow)
            int[] digitValues = new int[digitNr + 2]; 
            while (digitNr >= 0)
            {
                var digitWeight = BigInteger.Pow(Snafu.ValuesPerDigit, digitNr);
                digitValues[digitNr] = (int)(remainder / digitWeight);
                remainder = remainder % digitWeight;
                digitNr--;
            }
            return digitValues;
        }

        private int[] ConvertBase5DigitsToSnafuDigits(int[] digitValues)
        {
            int[] snafuDigitIntValues = new int[digitValues.Length];
            int overflow = 0;
            for (int i = 0; i < digitValues.Length; i++)
            {
                var value = digitValues[i] + overflow;
                overflow = 0;
                if (value > Snafu.MaxDigitValue)
                {
                    overflow = 1;
                    value -= Snafu.ValuesPerDigit;
                }
                snafuDigitIntValues[(digitValues.Length-i)-1] = value;
            }
            return snafuDigitIntValues;
        }

        private string CreateSnafuString(int[] snafuDigitIntValues)
        {
            var numberOfLeadingZeros = 0;
            if (snafuDigitIntValues[0] == 0)
                numberOfLeadingZeros = 1;

            var snafuDigits = snafuDigitIntValues
                .Skip(numberOfLeadingZeros)
                .Select(d => ToChar(d));

            return string.Join("", snafuDigits);
        }

        public char ToChar(int value)
        {
            switch (value)
            {
                case -2: return '=';
                case -1: return '-';
                case 0: return '0';
                case 1: return '1';
                case 2: return '2';

                default:
                    throw new ArgumentOutOfRangeException($"{nameof(value)} = {value}, range = {{'=', '-', '0', '1', '2'}}");
            }
        }
    }
}