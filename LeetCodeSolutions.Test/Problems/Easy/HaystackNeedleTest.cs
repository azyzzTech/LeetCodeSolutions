/// <summary>
/// 28. Find the Index of the First Occurrence in a String
/// <para>
/// Given two strings <paramref name="needle"/> and <paramref name="haystack"/>, return 
/// the index of the first occurrence of <paramref name="needle"/> in <paramref name="haystack"/>, 
/// or -1 if <paramref name="needle"/> is not part of <paramref name="haystack"/>.
/// </para>
/// <para>
/// Logic: Can be solved using a simple sliding window (substring comparison) or 
/// more advanced algorithms like KMP (Knuth-Morris-Pratt) for better efficiency in large datasets.
/// </para>
/// <example>
/// Example: haystack = "sadbutsad", needle = "sad" -> Output: 0
/// </example>
/// </summary>
/// <param name="haystack">The string to search within.</param>
/// <param name="needle">The substring to find.</param>
/// <returns>The first index of the needle, or -1 if not found.</returns>
/// <remarks>
/// Time Complexity: $O(n \cdot m)$ for naive approach or $O(n + m)$ for KMP.
/// Space Complexity: $O(1)$ for naive or $O(m)$ for KMP to store the prefix table.
/// </remarks>

using static LeetCodeSolutions.Core.Problems.Easy.HaystackNeedleSolution;

namespace LeetCodeSolutions.Test.Problems.Easy;

public class HaystackNeedleTest
{
    [Theory]
    [InlineData("sadbutsad", "sad", 0)]
    [InlineData("leetcode", "leeto", -1)]
    [InlineData("hello", "ll", 2)]
    [InlineData("aaaaa", "bba", -1)]
    [InlineData("abc", "", 0)]
    public void StrStr_ReturnsExpectedIndex(string haystack, string needle, int expected)
        => Assert.Equal(expected, StrStr(haystack, needle));
}
