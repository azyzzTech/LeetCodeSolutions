/// <summary>
/// 29. Divide Two Integers
/// <para>
/// Given two integers <paramref name="dividend"/> and <paramref name="divisor"/>, divide 
/// them without using multiplication, division, or the mod operator.
/// </para>
/// <para>
/// Logic: Use bit manipulation (left shifts) to find the largest multiple of the divisor 
/// that fits into the dividend in each step. This effectively performs division in 
/// logarithmic time relative to the value of the quotient.
/// </para>
/// <example>
/// Example: dividend = 10, divisor = 3 -> Output: 3
/// </example>
/// </summary>
/// <param name="dividend">The number to be divided.</param>
/// <param name="divisor">The number to divide by.</param>
/// <returns>The integer quotient, clamped to the 32-bit signed integer range.</returns>
/// <remarks>
/// Time Complexity: $O((\log n)^2)$ or $O(\log n)$ depending on bit-shift optimization.
/// Space Complexity: $O(1)$ - No extra data structures used.
/// </remarks>

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
