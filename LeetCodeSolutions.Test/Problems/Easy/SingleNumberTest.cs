using LeetCodeSolutions.Core.Problems.Easy;

namespace LeetCodeSolutions.Test.Problems.Easy;

public class SingleNumberTest
{
    [Theory]
    [InlineData(new int[] { 2, 2, 1 }, 1)]
    [InlineData(new int[] { 4, 1, 2, 1, 2 }, 4)]
    [InlineData(new int[] { 1 }, 1)]
    public void SingleNumber_ReturnsExpectedResult(int[] nums, int expected)
    {
        var solution = new SingleNumberSolution();
        var result = solution.SingleNumber(nums);
        Assert.Equal(expected, result);
    }
}
