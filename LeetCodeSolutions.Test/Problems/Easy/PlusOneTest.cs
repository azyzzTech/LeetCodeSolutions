/// <summary>
/// 66. Plus One
/// <para>
/// You are given a large integer represented as an integer array <paramref name="digits"/>, 
/// where each <c>digits[i]</c> is the $i^{th}$ digit of the integer. The digits are ordered 
/// from most significant to least significant in left-to-right order. 
/// Increment the large integer by one and return the resulting array of digits.
/// </para>
/// <para>
/// Logic: Iterate through the array starting from the last element (least significant digit). 
/// If a digit is less than 9, increment it and return the array immediately. If it is 9, 
/// set it to 0 and continue to the next digit (carrying the one). If all digits are 9, 
/// create a new array with a length of $n + 1$ and set the first element to 1.
/// </para>
/// <example>
/// Example 1: digits = [1,2,3] -> Output: [1,2,4]
/// Example 2: digits = [4,3,2,1] -> Output: [4,3,2,2]
/// Example 3: digits = [9] -> Output: [1,0]
/// </example>
/// </summary>
/// <param name="digits">An array representing the digits of a large integer.</param>
/// <returns>An array representing the digits after incrementing the integer by one.</returns>
/// <remarks>
/// Time Complexity: $O(n)$ - In the worst case (all 9s), we traverse the entire array once.
/// Space Complexity: $O(n)$ - Usually $O(1)$ if we modify in-place, but $O(n)$ when all digits are 9 and a new array is required.
/// </remarks>

using static LeetCodeSolutions.Core.Problems.Easy.PlusOneSolution;

namespace LeetCodeSolutions.Test.Problems.Easy;

public class PlusOneTest
{
    [Theory]
    [InlineData(new int[] { 1, 2, 3 }, new int[] { 1, 2, 4 })]
    [InlineData(new int[] { 4, 3, 2, 1 }, new int[] { 4, 3, 2, 2 })]
    [InlineData(new int[] { 9 }, new int[] { 1, 0 })]
    public void PlusOne_ReturnsExpectedResult(int[] digits, int[] expected)
        => Assert.Equal(expected, PlusOne(digits));
}
