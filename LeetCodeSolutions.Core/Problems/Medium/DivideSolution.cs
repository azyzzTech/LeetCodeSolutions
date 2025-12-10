namespace LeetCodeSolutions.Core.Problems.Medium;

public class DivideSolution
{
    public static int Divide(int dividend, int divisor)
    {
        if (dividend == int.MinValue && divisor == -1)
        {
            return int.MaxValue;
        }

        bool isNegative = (dividend < 0) ^ (divisor < 0);

        long absDividend = Math.Abs((long)dividend);
        long absDivisor = Math.Abs((long)divisor);

        int result = 0;

        while (absDividend >= absDivisor)
        {
            long tempDivisor = absDivisor;
            long multiple = 1;

            while (absDividend >= (tempDivisor << 1))
            {
                tempDivisor <<= 1;
                multiple <<= 1;
            }

            absDividend -= tempDivisor;
            result += (int)multiple;
        }

        return isNegative ? -result : result;
    }
}
