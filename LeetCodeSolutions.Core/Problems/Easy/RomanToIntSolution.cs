/// <summary>
/// 13. Roman to Integer
/// <para>
/// Converts a Roman numeral string <paramref name="s"/> back into an integer.
/// </para>
/// <para>
/// Logic: Iterate through the string; if the value of the current symbol is less than the 
/// value of the next symbol, subtract it (subtractive rule). Otherwise, add it.
/// </para>
/// <example>
/// Example: s = "LVIII" -> Output: 58 (L=50, V=5, III=3)
/// </example>
/// </summary>
/// <param name="s">The Roman numeral string.</param>
/// <returns>The integer value of the Roman numeral.</returns>
/// <remarks>
/// Time Complexity: $O(n)$ - Single pass through the string.
/// Space Complexity: $O(1)$ - Constant space for symbol mapping.
/// </remarks>

namespace LeetCodeSolutions.Core.Problems.Easy;

public class RomanToIntSolution
{
    public static int RomanToInt(string s)
    {
        static int Value(char c) => c switch
        {
            'I' => 1,
            'V' => 5,
            'X' => 10,
            'L' => 50,
            'C' => 100,
            'D' => 500,
            'M' => 1000,
            _ => 0
        };

        int result = 0;

        for (int i = 0; i < s.Length; i++)
        {
            if (i + 1 < s.Length && Value(s[i + 1]) > Value(s[i]))
                result -= Value(s[i]);
            else
                result += Value(s[i]);
        }

        return result;
    }
}