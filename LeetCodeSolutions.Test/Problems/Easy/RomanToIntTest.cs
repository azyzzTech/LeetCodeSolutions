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

namespace LeetCodeSolutions.Test.Problems.Easy;

public class RomanToIntTest
{
    [Fact]
    public void MethodUnderTest_ExpectedBehavior_StateUnderTest()
    {
        // Arrange


        // Act


        // Assert

    }
}