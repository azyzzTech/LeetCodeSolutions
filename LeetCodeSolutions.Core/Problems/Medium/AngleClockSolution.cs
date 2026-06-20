/// <summary>
/// 1344. Angle Between Hands of a Clock
/// <para>
/// Given the hour and minutes of a traditional analog clock, return the smaller angle (in degrees)
/// formed between the hour and minute hands.
/// </para>
/// <para>
/// Input: two integers hour and minutes where 1 <= hour <= 12 and 0 <= minutes < 60.
/// Output: the smallest angle between the hour and minute hands in degrees.
/// </para>
/// <example>
/// Input: hour = 3, minutes = 30 -> Output: 75.0
/// </example>
/// </summary>
/// <param name="hour">Hour on the clock (1..12).</param>
/// <param name="minutes">Minutes on the clock (0..59).</param>
/// <returns>The smallest angle between the hour and minute hands in degrees.</returns>
/// <remarks>
/// Constraints: 1 <= hour <= 12, 0 <= minutes < 60.
/// </remarks>

namespace LeetCodeSolutions.Core.Problems.Medium;

public class AngleClockSolution
{
    public double AngleClock(int hour, int minutes)
    {
        double hourAngle = (hour % 12) * 30 + (minutes / 60.0) * 30;
        double minuteAngle = minutes * 6;
        double angle = Math.Abs(hourAngle - minuteAngle);
        return Math.Min(angle, 360 - angle);
    }
}
