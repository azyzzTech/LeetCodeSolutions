/// <summary>
/// 3. Longest Substring Without Repeating Characters
/// <para>
/// Given a string <paramref name="s"/>, find the length of the longest substring 
/// without repeating characters.
/// </para>
/// <para>
/// Logic: Uses a "Sliding Window" approach with two pointers (<c>left</c> and <c>right</c>). 
/// As the <c>right</c> pointer expands the window, we check if the character is already in our set. 
/// If it is, we shrink the window from the <c>left</c> until the duplicate is removed.
/// </para>
/// <example>
/// Example 1: s = "abcabcbb" -> Output: 3 (The answer is "abc")
/// Example 2: s = "bbbbb" -> Output: 1 (The answer is "b")
/// Example 3: s = "pwwkew" -> Output: 3 (The answer is "wke")
/// </example>
/// </summary>
/// <param name="s">The input string to analyze.</param>
/// <returns>The length of the longest substring consisting of unique characters.</returns>
/// <remarks>
/// Time Complexity: $O(n)$ - Each character is visited at most twice (once by each pointer).
/// Space Complexity: $O(min(m, n))$ - Where $n$ is the length of the string and $m$ is the size of the character set (e.g., 26 for English letters, 128 for ASCII).
/// </remarks>


namespace LeetCodeSolutions.Test.Problems.Medium;

public class LengthOfLongestSubstringTest
{
}
