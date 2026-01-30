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

namespace LeetCodeSolutions.Test.Problems.Easy;

public class LongestCommonPrefixTest
{
    [Theory]
    [InlineData(new string[] { "flower", "flow", "flight" }, "fl")]
    [InlineData(new string[] { "dog", "racecar", "car" }, "")]
    [InlineData(new string[] { "interspecies", "interstellar", "interstate" }, "inters")]
    [InlineData(new string[] { "a" }, "a")]
    [InlineData(new string[] { "", "" }, "")]
    public void LongestCommonPrefix_ReturnsExpectedPrefix(string[] strs, string expected)
    {
        var result = Core.Problems.Easy.LongestCommonPrefixSolution.LongestCommonPrefix(strs);
        Assert.Equal(expected, result);
    }
}
