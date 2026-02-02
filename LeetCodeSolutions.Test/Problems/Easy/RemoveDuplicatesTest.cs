/// <summary>
/// 26. Remove Duplicates from Sorted Array
/// <para>
/// Given an integer array <paramref name="nums"/> sorted in non-decreasing order, remove the duplicates 
/// in-place such that each unique element appears only once. The relative order of the elements 
/// should be kept the same.
/// </para>
/// <para>
/// Logic: Uses a two-pointer approach. The <c>slow</c> pointer tracks the position of the last 
/// unique element found, while the <c>fast</c> pointer iterates through the array to find new unique values.
/// </para>
/// <example>
/// Example: nums = [0,0,1,1,1,2,2,3,3,4] -> Output: 5, nums = [0,1,2,3,4,_,_,_,_,_]
/// </example>
/// </summary>
/// <param name="nums">The sorted integer array to modify.</param>
/// <returns>The number of unique elements in the array.</returns>
/// <remarks>
/// Time Complexity: $O(n)$ - Single pass through the array.
/// Space Complexity: $O(1)$ - Modification is done in-place.
/// </remarks>

using static LeetCodeSolutions.Core.Problems.Easy.RemoveDuplicatesSolution;

namespace LeetCodeSolutions.Test.Problems.Easy;

public class RemoveDuplicatesTest
{
    [Theory]
    [InlineData(new int[] { 1, 1, 2 }, 2, new int[] { 1, 2 })]
    [InlineData(new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 }, 5, new int[] { 0, 1, 2, 3, 4 })]
    public void RemoveDuplicates_ReturnsExpectedResult(int[] nums, int expectedLength, int[] expectedNums)
    {
        int length = RemoveDuplicates(nums);
        Assert.Equal(expectedLength, length);
        Assert.Equal(expectedNums, nums[..length]);
    }
}
