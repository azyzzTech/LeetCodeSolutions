using LeetCodeSolutions.Core.Problems.Medium;

namespace LeetCodeSolutions.Test.Problems.Medium;

public class AngleClockTest
{
    [Theory]
    [InlineData(12, 30, 165)]
    [InlineData(3, 30, 75)]
    [InlineData(3, 15, 7.5)]
    public void AngleClock_ReturnsCorrectAngle(int hour, int minutes, double expected)
    {
        var solution = new AngleClockSolution();
        var result = solution.AngleClock(hour, minutes);
        Assert.Equal(expected, result);
    }
}