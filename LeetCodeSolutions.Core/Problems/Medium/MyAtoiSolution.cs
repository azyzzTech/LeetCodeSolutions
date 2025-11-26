namespace LeetCodeSolutions.Core.Problems.Medium;

public class MyAtoiSolution
{
    public static int MyAtoi(string s)
    {
        int index = 0;
        long result = 0;

        while (index < s.Length && s[index] == ' ')
            index++;

        if (index == s.Length)
            return 0;

        int sign = 1;

        if (s[index] == '+' || s[index] == '-')
        {
            sign = (s[index] == '-') ? -1 : 1;
            index++;
        }

        while (index < s.Length && char.IsDigit(s[index]))
        {
            int digit = s[index] - '0';
            if (sign == 1 && (result > int.MaxValue / 10 || (result == int.MaxValue / 10 && digit > 7)))
                return int.MaxValue;
            else if (result > int.MaxValue / 10 || (result == int.MaxValue / 10 && digit > 8))
                return int.MinValue;

            result = result * 10 + digit;
            index++;
        }

        return (int)(result * sign);
    }
}
