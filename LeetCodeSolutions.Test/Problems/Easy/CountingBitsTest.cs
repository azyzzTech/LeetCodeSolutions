using LeetCodeSolutions.Core.Problems.Easy;

namespace LeetCodeSolutions.Test.Problems.Easy;

public class CountingBitsTest
{
    [Theory]
    [InlineData(0, new int[] { 0 })]
    [InlineData(2, new int[] { 0, 1, 1 })]
    [InlineData(5, new int[] { 0, 1, 1, 2, 1, 2 })]
    public void CountBits_ReturnsExpectedResult(int n, int[] expected)
    {
        var solution = new CountingBitsSolution();
        var result = solution.CountBits(n);
        Assert.Equal(expected, result);
    }
}
