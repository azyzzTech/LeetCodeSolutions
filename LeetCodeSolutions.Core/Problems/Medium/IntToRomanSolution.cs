/// <summary>
/// 12. Integer to Roman
/// <para>
/// Converts an integer <paramref name="num"/> (range 1 to 3999) to a Roman numeral string.
/// </para>
/// <para>
/// Logic: A greedy approach is used by storing Roman symbols and their values in descending order. 
/// We subtract the largest possible value from the number repeatedly until it reaching zero.
/// </para>
/// <example>
/// Example: num = 3749 -> Output: "MMMDCCXLIX"
/// </example>
/// </summary>
/// <param name="num">The integer to convert.</param>
/// <returns>The Roman numeral representation of the integer.</returns>
/// <remarks>
/// Time Complexity: $O(1)$ - Since the input is capped at 3999, the number of iterations is fixed.
/// Space Complexity: $O(1)$ - Fixed size arrays for mapping symbols.
/// </remarks>

namespace LeetCodeSolutions.Core.Problems.Medium;

public class IntToRomanSolution
{
    public static string IntToRoman(int num)
    {
        string[] M = { "", "M", "MM", "MMM" };
        string[] C = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
        string[] X = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
        string[] I = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };

        return M[num / 1000] +
               C[(num % 1000) / 100] +
               X[(num % 100) / 10] +
               I[num % 10];
    }
}
