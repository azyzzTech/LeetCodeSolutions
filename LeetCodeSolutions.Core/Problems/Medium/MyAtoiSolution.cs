/// <summary>
/// 8. String to Integer (atoi)
/// <para>
/// Implements the <c>myAtoi(string s)</c> function, which converts a string to a 32-bit signed integer 
/// by following a specific sequence of steps:
/// 1. <b>Whitespace:</b> Ignore any leading whitespace.
/// 2. <b>Signedness:</b> Check if the next character is '-' or '+'.
/// 3. <b>Conversion:</b> Read in next characters until the next non-digit character or the end of the input is reached.
/// 4. <b>Rounding:</b> If the integer is out of the 32-bit signed integer range, clamp it to <c>Int32.MinValue</c> or <c>Int32.MaxValue</c>.
/// </para>
/// <example>
/// Example 1: s = "42" -> Output: 42
/// Example 2: s = " -042" -> Output: -42
/// Example 3: s = "1337c0d3" -> Output: 1337
/// Example 4: s = "0-1" -> Output: 0
/// </example>
/// </summary>
/// <param name="s">The string to be converted into an integer.</param>
/// <returns>The resulting 32-bit signed integer, or the clamped boundary value if an overflow occurs.</returns>
/// <remarks>
/// Time Complexity: $O(n)$ - We perform a single pass through the string where $n$ is the length of <paramref name="s"/>.
/// Space Complexity: $O(1)$ - Only a constant amount of space is used to store the sign and the result.
/// </remarks>

namespace LeetCodeSolutions.Core.Problems.Medium;

public class MyAtoiSolution
{
    public static int MyAtoi(string s)
    {
        int index = 0;
        long result = 0;

        while (index < s.Length && s[index] == ' ')
            index++;

        if (index == s.Length)
            return 0;

        int sign = 1;

        if (s[index] == '+' || s[index] == '-')
        {
            sign = (s[index] == '-') ? -1 : 1;
            index++;
        }

        while (index < s.Length && char.IsDigit(s[index]))
        {
            int digit = s[index] - '0';
            if (sign == 1 && (result > int.MaxValue / 10 || (result == int.MaxValue / 10 && digit > 7)))
                return int.MaxValue;
            else if (result > int.MaxValue / 10 || (result == int.MaxValue / 10 && digit > 8))
                return int.MinValue;

            result = result * 10 + digit;
            index++;
        }

        return (int)(result * sign);
    }
}
