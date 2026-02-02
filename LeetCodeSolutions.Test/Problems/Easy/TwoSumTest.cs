/// <summary>
/// 1. Two Sum
/// <para>
/// Given an array of integers <paramref name="nums"/> and an integer <paramref name="target"/>, 
/// return indices of the two numbers such that they add up to <paramref name="target"/>.
/// </para>
/// <para>
/// Logic: This solution typically uses a Hash Map (Dictionary in C#) to provide a lookup in near-constant time. 
/// As we iterate through the array, we calculate the <c>complement</c> (target - current value) 
/// and check if it already exists in our map.
/// </para>
/// <example>
/// Example: nums = [2, 7, 11, 15], target = 9 
/// <br/>Process: 
/// 1. Loop finds 2, complement is 7. 7 not in map. Store {2: 0}.
/// 2. Loop finds 7, complement is 2. 2 is in map! Return [0, 1].
/// </example>
/// </summary>
/// <param name="nums">An array of integers.</param>
/// <param name="target">The integer target sum.</param>
/// <returns>An array of two integers representing the indices of the numbers that sum to the target.</returns>
/// <remarks>
/// Time Complexity: $O(n)$ - We traverse the list containing $n$ elements only once. Each look up in the table costs only $O(1)$ time.
/// Space Complexity: $O(n)$ - The extra space depends on the number of items stored in the hash table, which stores at most $n$ elements.
/// </remarks>

using static LeetCodeSolutions.Core.Problems.Easy.TwoSumSolution;

namespace LeetCodeSolutions.Test.Problems.Easy;

public class TwoSumTest
{
    [Theory]
    [InlineData(new int[] { 2, 7, 11, 15 }, 9, new int[] { 0, 1 })]
    [InlineData(new int[] { 3, 2, 4 }, 6, new int[] { 1, 2 })]
    [InlineData(new int[] { 3, 3 }, 6, new int[] { 0, 1 })]
    public void TwoSum_ReturnsExpectedResult(int[] nums, int target, int[] expected)
        => Assert.Equal(expected, TwoSum(nums, target));
}
