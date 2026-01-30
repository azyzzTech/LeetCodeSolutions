/// <summary>
/// 4. Median of Two Sorted Arrays
/// <para>
/// Given two sorted arrays <paramref name="nums1"/> and <paramref name="nums2"/> of size <c>m</c> and <c>n</c> respectively, 
/// return the median of the two sorted arrays.
/// </para>
/// <para>
/// Logic: To achieve the required logarithmic time complexity, we perform a binary search on the <b>partition</b> 
/// of the smaller array. We aim to find a cut point such that all elements to the left of the partition are 
/// less than or equal to all elements to the right. 
/// If $(m + n)$ is even, the median is the average of the max-left and min-right. 
/// If $(m + n)$ is odd, the median is the max-left.
/// </para>
/// <example>
/// Example 1: nums1 = [1, 3], nums2 = [2] -> Output: 2.00000
/// Example 2: nums1 = [1, 2], nums2 = [3, 4] -> Output: 2.50000 ( (2+3)/2 )
/// </example>
/// </summary>
/// <param name="nums1">The first sorted integer array.</param>
/// <param name="nums2">The second sorted integer array.</param>
/// <returns>The median value as a double.</returns>
/// <remarks>
/// Time Complexity: $O(\log(\min(m, n)))$ - Binary search is performed on the smaller array.
/// Space Complexity: $O(1)$ - Only a constant amount of extra space is used for pointers and variables.
/// </remarks>

namespace LeetCodeSolutions.Test.Problems.Hard;

public class FindMedianSortedArraysTest
{
    [Fact]
    public void MethodUnderTest_ExpectedBehavior_StateUnderTest()
    {
        // Arrange


        // Act


        // Assert

    }
}