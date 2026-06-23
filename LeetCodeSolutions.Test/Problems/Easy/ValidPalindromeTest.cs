using LeetCodeSolutions.Core.Problems.Easy;

namespace LeetCodeSolutions.Test.Problems.Easy;

public class ValidPalindromeTest
{
    [Theory]
    [InlineData("A man, a plan, a canal: Panama", true)]
    [InlineData("race a car", false)]
    [InlineData("", true)]
    [InlineData(" ", true)]
    [InlineData("0P", false)]
    [InlineData("ab_a", true)]
    public void IsPalindrome_VariousInputs_ReturnsExpected(string input, bool expected)
    {
        var sut = new ValidPalindromeSolution();
        var result = sut.IsPalindrome(input);
        Assert.Equal(expected, result);
    }
}
