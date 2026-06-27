/// <summary>
/// 136. Single Number
/// <para>
/// Given a non-empty array of integers <paramref name="nums"/>, every element appears twice 
/// except for one. Find that single one.
/// </para>
/// <para>
/// You must implement a solution with a linear runtime complexity and use only constant extra space.
/// </para>
/// <example>
/// Example 1: nums = [2,2,1] -> Output: 1
/// Example 2: nums = [4,1,2,1,2] -> Output: 4
/// Example 3: nums = [1] -> Output: 1
/// </example>
/// </summary>
/// <param name="nums">A non-empty array of integers where every element appears twice except for one.</param>
/// <returns>The element that appears only once.</returns>
/// <remarks>
/// Time Complexity: $O(n)$ - We iterate through the array exactly once.
/// Space Complexity: $O(1)$ - We use a constant amount of extra space regardless of input size.
/// </remarks>

namespace LeetCodeSolutions.Core.Problems.Easy;

public class SingleNumberSolution
{
    public int SingleNumber(int[] nums)
    {
        int result = 0;
        foreach (int num in nums)
        {
            result ^= num;
        }
        return result;
    }
}
