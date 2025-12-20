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

namespace LeetCodeSolutions.Core.Problems.Easy;

public class PalindromeNumberSolution
{
    public static bool IsPalindrome(int x)
    {
        if (x < 0 || (x % 10 == 0 && x != 0))
        {
            return false;
        }

        int reversedNumber = 0;

        while (x > reversedNumber)
        {
            int digit = x % 10;
            reversedNumber = reversedNumber * 10 + digit;
            x /= 10;
        }

        return x == reversedNumber || x == reversedNumber / 10;
    }
}