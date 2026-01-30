/// <summary>
/// 70. Climbing Stairs
/// <para>
/// You are climbing a staircase. It takes <paramref name="n"/> steps to reach the top.
/// Each time you can either climb 1 or 2 steps. In how many distinct ways can you climb to the top?
/// </para>
/// <para>
/// Logic: This is a classic <b>Dynamic Programming</b> problem that follows the Fibonacci sequence pattern.
/// To reach step <c>i</c>, you could have come from step <c>i-1</c> (by taking 1 step) 
/// or from step <c>i-2</c> (by taking 2 steps). 
/// Therefore, <c>ways(i) = ways(i-1) + ways(i-2)</c>.
/// </para>
/// <example>
/// Example 1: n = 2 -> Output: 2 (1+1, 2)
/// Example 2: n = 3 -> Output: 3 (1+1+1, 1+2, 2+1)
/// </example>
/// </summary>
/// <param name="n">The total number of steps to reach the top.</param>
/// <returns>The number of distinct ways to reach the top.</returns>
/// <remarks>
/// Time Complexity: $O(n)$ - We calculate the number of ways for each step up to $n$.
/// Space Complexity: $O(1)$ - We only need to store the last two calculated values (iterative approach).
/// </remarks>

using static LeetCodeSolutions.Core.Problems.Easy.ClimbStairsSolution;

namespace LeetCodeSolutions.Test.Problems.Easy;

public class ClimbStairsTest
{
    [Theory]
    [InlineData(2, 2)]
    [InlineData(3, 3)]
    [InlineData(4, 5)]
    [InlineData(5, 8)]
    public void ClimbStairs_ReturnsExpectedResult(int n, int expected)
        => Assert.Equal(expected, ClimbStairs(n));
}
