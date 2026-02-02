/// <summary>
/// 9. Palindrome Number
/// <para>
/// Determines whether an integer <paramref name="x"/> is a palindrome. An integer is a 
/// palindrome when it reads the same backward as forward.
/// </para>
/// <para>
/// Logic: Negative numbers are never palindromes. For positive numbers, we can reverse 
/// the second half of the number and compare it with the first half to avoid overflow 
/// issues that might occur when reversing the entire number.
/// </para>
/// <example>
/// Example: x = 121 -> Output: true | x = -121 -> Output: false | x = 10 -> Output: false
/// </example>
/// </summary>
/// <param name="x">The integer to check.</param>
/// <returns>True if <paramref name="x"/> is a palindrome, false otherwise.</returns>
/// <remarks>
/// Time Complexity: $O(\log_{10}(n))$ - We divide the input by 10 in every iteration.
/// Space Complexity: $O(1)$ - Constant space used.
/// </remarks>

using static LeetCodeSolutions.Core.Problems.Easy.PalindromeNumberSolution;

namespace LeetCodeSolutions.Test.Problems.Easy;

public class PalindromeNumberTest
{
    [Theory]
    [InlineData(121, true)]
    [InlineData(-121, false)]
    [InlineData(10, false)]
    [InlineData(0, true)]
    [InlineData(1, true)]
    [InlineData(12321, true)]
    [InlineData(1221, true)]
    [InlineData(123, false)]
    [InlineData(1000, false)]
    [InlineData(9, true)]
    public void IsPalindrome_ReturnsExpectedResult(int x, bool expected)
        => Assert.Equal(expected, IsPalindrome(x));
}
