/// <summary>
/// 69. Sqrt(x)
/// <para>
/// Given a non-negative integer <paramref name="x"/>, return the square root of <paramref name="x"/> 
/// rounded down to the nearest integer. The returned integer should be non-negative as well.
/// You must not use any built-in exponent function or operator (e.g., <c>pow(x, 0.5)</c> or <c>x ** 0.5</c>).
/// </para>
/// <para>
/// Logic: Since the square root of <paramref name="x"/> is guaranteed to be within the range [0, x], 
/// we can use <b>Binary Search</b> to find the largest integer <c>k</c> such that $k^2 \le x$. 
/// To prevent integer overflow during the calculation of $mid \times mid$, we use <c>long</c> 
/// or division-based comparison (<c>mid \le x / mid</c>).
/// </para>
/// <example>
/// Example 1: x = 4 -> Output: 2
/// Example 2: x = 8 -> Output: 2 (The square root of 8 is 2.82842..., and rounding down returns 2)
/// </example>
/// </summary>
/// <param name="x">The non-negative integer to calculate the square root for.</param>
/// <returns>The integer part of the square root of <paramref name="x"/>.</returns>
/// <remarks>
/// Time Complexity: $O(\log n)$ - Binary search reduces the search space by half in each step.
/// Space Complexity: $O(1)$ - Only a constant amount of extra space is used.
/// </remarks>

using static LeetCodeSolutions.Core.Problems.Easy.MySqrtSolution;

namespace LeetCodeSolutions.Test.Problems.Easy;

public class MySqrtTest
{
    [Theory]
    [InlineData(4, 2)]
    [InlineData(8, 2)]
    [InlineData(0, 0)]
    [InlineData(1, 1)]
    [InlineData(16, 4)]
    [InlineData(2147395599, 46339)]
    public void MySqrt_ReturnsExpectedResult(int x, int expected)
        => Assert.Equal(expected, MySqrt(x));
}
