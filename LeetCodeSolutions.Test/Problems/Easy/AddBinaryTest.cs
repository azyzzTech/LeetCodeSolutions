/// <summary>
/// 67. Add Binary
/// <para>
/// Given two binary strings <paramref name="a"/> and <paramref name="b"/>, return their sum as a binary string.
/// </para>
/// <para>
/// Logic: We use a pointer-based approach starting from the end of both strings (the least significant bit). 
/// In each iteration, we sum the bits from <paramref name="a"/> and <paramref name="b"/> along with any 
/// <c>carry</c> from the previous step. The current bit is <c>sum % 2</c> and the new carry is <c>sum / 2</c>.
/// </para>
/// <example>
/// Example 1: a = "11", b = "1" -> Output: "100"
/// Example 2: a = "1010", b = "1011" -> Output: "10101"
/// </example>
/// </summary>
/// <param name="a">The first binary string.</param>
/// <param name="b">The second binary string.</param>
/// <returns>A string representing the binary sum of the two inputs.</returns>
/// <remarks>
/// Time Complexity: $O(\max(N, M))$ - We iterate through the longer of the two strings once.
/// Space Complexity: $O(\max(N, M))$ - To store the result in a StringBuilder or character array.
/// </remarks>

using static LeetCodeSolutions.Core.Problems.Easy.AddBinarySolution;

namespace LeetCodeSolutions.Test.Problems.Easy;

public class AddBinaryTest
{
    [Theory]
    [InlineData("11", "1", "100")]
    [InlineData("1010", "1011", "10101")]
    [InlineData("0", "0", "0")]
    [InlineData("1", "0", "1")]
    [InlineData("111", "111", "1110")]
    public void AddBinary_ReturnsExpectedResult(string a, string b, string expected) 
        => Assert.Equal(expected, AddBinary(a, b));
}
