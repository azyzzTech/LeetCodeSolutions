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

namespace LeetCodeSolutions.Core.Problems.Easy;

public class HaystackNeedleSolution
{
    public static int StrStr(string haystack, string needle)
    {
        return haystack.IndexOf(needle, 0, StringComparison.Ordinal);
    }
}
