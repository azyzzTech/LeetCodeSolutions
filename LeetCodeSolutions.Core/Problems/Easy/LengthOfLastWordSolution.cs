/// <summary>
/// 58. Length of Last Word
/// <para>
/// Given a string <paramref name="s"/> consisting of words and spaces, return the length 
/// of the last word in the string. A word is a maximal substring consisting of non-space characters only.
/// </para>
/// <para>
/// Logic: Start from the end of the string, skip any trailing spaces, and then count 
/// the characters until the next space or the start of the string is reached.
/// </para>
/// <example>
/// Example: s = "   fly me   to   the moon  " -> Output: 4 ("moon")
/// </example>
/// </summary>
/// <param name="s">The input string.</param>
/// <returns>The length of the last word in the string.</returns>
/// <remarks>
/// Time Complexity: $O(n)$ - In the worst case, we traverse the string once.
/// Space Complexity: $O(1)$ - Constant space used.
/// </remarks>

namespace LeetCodeSolutions.Core.Problems.Easy;

public class LengthOfLastWordSolution
{
    public static int LengthOfLastWord(string s)
    {
        return s.Split(' ', StringSplitOptions.RemoveEmptyEntries).Last().Length;
    }
}
