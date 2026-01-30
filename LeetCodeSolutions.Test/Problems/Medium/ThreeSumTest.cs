/// <summary>
/// 15. 3Sum
/// <para>
/// Given an integer array, returns all unique triplets [nums[i], nums[j], nums[k]] 
/// such that i != j, i != k, and j != k, and their sum is zero.
/// </para>
/// <para>
/// Logic: Sort the array and use a fixed pointer <c>i</c> combined with two pointers 
/// (<c>low</c> and <c>high</c>) to find the remaining two numbers. Skip duplicate values 
/// to ensure the output triplets are unique.
/// </para>
/// <example>
/// Example: nums = [-1,0,1,2,-1,-4] -> Output: [[-1,-1,2],[-1,0,1]]
/// </example>
/// </summary>
/// <param name="nums">The input integer array.</param>
/// <returns>A list of all unique triplets that sum to zero.</returns>
/// <remarks>
/// Time Complexity: $O(n^2)$ - Sorting takes $O(n \log n)$, then a nested loop with two pointers takes $O(n^2)$.
/// Space Complexity: $O(n)$ or $O(\log n)$ - Depending on the sorting implementation.
/// </remarks>


namespace LeetCodeSolutions.Test.Problems.Medium;

public class ThreeSumTest
{
}
