/// <summary>
/// 7. Reverse Integer
/// <para>
/// Given a signed 32-bit integer <paramref name="x"/>, return <paramref name="x"/> with its digits reversed. 
/// If reversing <paramref name="x"/> causes the value to go outside the signed 32-bit integer range 
/// $[-2^{31}, 2^{31} - 1]$, then return 0.
/// </para>
/// <para>
/// Logic: The process involves iteratively "popping" the last digit of <paramref name="x"/> using the modulo operator (<c>% 10</c>) 
/// and "pushing" it onto a new reversed variable. Before each push, we check if the current value 
/// multiplied by 10 will exceed the bounds of a 32-bit signed integer.
/// </para>
/// <example>
/// Example 1: x = 123 -> Output: 321
/// Example 2: x = -123 -> Output: -321
/// Example 3: x = 120 -> Output: 21
/// </example>
/// </summary>
/// <param name="x">The signed 32-bit integer to be reversed.</param>
/// <returns>The reversed integer if it stays within bounds; otherwise, 0.</returns>
/// <remarks>
/// Time Complexity: $O(\log_{10}(n))$ - The number of iterations is equal to the number of digits in $x$.
/// Space Complexity: $O(1)$ - Only a few variables are used to store the result and the remainder.
/// </remarks>

namespace LeetCodeSolutions.Core.Problems.Medium;

public class ReverseSolution
{
    public static int Reverse(int x)
    {
        int result = 0;

        while (x != 0)
        {
            int lastNum = x % 10;
            x /= 10;

            if (result > int.MaxValue / 10 || (result == int.MaxValue / 10 && lastNum > 7))
                return 0;

            if (result < int.MinValue / 10 || (result == int.MaxValue / 10 && lastNum < -8))
                return 0;

            result = result * 10 + lastNum;
        }

        return result;
    }
}
