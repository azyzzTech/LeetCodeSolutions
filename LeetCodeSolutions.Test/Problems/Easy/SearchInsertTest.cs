/// <summary>
/// 35. Search Insert Position
/// <para>
/// Given a sorted array of distinct integers <paramref name="nums"/> and a <paramref name="target"/> value, 
/// return the index if the target is found. If not, return the index where it would be if it were inserted in order.
/// </para>
/// <para>
/// Logic: Implements a <b>Binary Search</b> algorithm to find the target in logarithmic time. 
/// If the target is not found by the end of the search, the <c>left</c> pointer (or low index) 
/// will naturally point to the correct insertion index.
/// </para>
/// <example>
/// Example 1: nums = [1,3,5,6], target = 5 -> Output: 2
/// Example 2: nums = [1,3,5,6], target = 2 -> Output: 1
/// Example 3: nums = [1,3,5,6], target = 7 -> Output: 4
/// </example>
/// </summary>
/// <param name="nums">A sorted array of distinct integers.</param>
/// <param name="target">The integer value to search for or insert.</param>
/// <returns>The index of the target if found, or the index where it would be inserted.</returns>
/// <remarks>
/// Time Complexity: $O(\log n)$ - The search space is halved in each iteration.
/// Space Complexity: $O(1)$ - Only a constant amount of extra space is used for pointers.
/// </remarks>


namespace LeetCodeSolutions.Test.Problems.Easy;

public class SearchInsertTest
{
}
