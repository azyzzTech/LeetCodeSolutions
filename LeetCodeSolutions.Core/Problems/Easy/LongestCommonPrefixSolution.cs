/// <summary>
/// 14. Longest Common Prefix
/// <para>
/// Finds the longest common prefix string amongst an array of strings.
/// </para>
/// <para>
/// Logic: Horizontal scanning (comparing the prefix against each word) or 
/// vertical scanning (comparing character by character at each index across all words).
/// </para>
/// <example>
/// Example: strs = ["flower","flow","flight"] -> Output: "fl"
/// </example>
/// </summary>
/// <param name="strs">An array of strings.</param>
/// <returns>The longest common prefix. If none, returns an empty string.</returns>
/// <remarks>
/// Time Complexity: $O(S)$ - Where $S$ is the sum of all characters in all strings.
/// Space Complexity: $O(1)$ - No extra space proportional to input.
/// </remarks>

namespace LeetCodeSolutions.Core.Problems.Easy;

public static class LongestCommonPrefixSolution
{
    public static string LongestCommonPrefix(string[] strs)
    {
        string firstWord = strs[0];
        int lengthOfFirst = firstWord.Length;

        for (int i = 0; i < lengthOfFirst; i++)
        {
            char currentChar = firstWord[i];

            for (int j = 1; j < strs.Length; j++)
            {
                if (i == strs[j].Length || strs[j][i] != currentChar)
                {
                    return firstWord.Substring(0, i);
                }
            }
        }

        return firstWord;
    }
}
