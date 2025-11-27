namespace LeetCodeSolutions.Core.Problems.Medium;

public class ReverseSolution
{
    public static int Reverse(int x)
    {
        int result = 0;

        while (x != 0)
        {
            int lastNum = x % 10;
            x /= 10;

            if (result > int.MaxValue / 10 || (result == int.MaxValue / 10 && lastNum > 7))
                return 0;

            if (result < int.MinValue / 10 || (result == int.MaxValue / 10 && lastNum < -8))
                return 0;

            result = result * 10 + lastNum;
        }

        return result;
    }
}
