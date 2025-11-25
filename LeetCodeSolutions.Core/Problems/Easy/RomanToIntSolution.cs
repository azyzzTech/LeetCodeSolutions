namespace LeetCodeSolutions.Core.Problems.Easy;

public class RomanToIntSolution
{
    public int RomanToInt(string s)
    {
        static int Value(char c) => c switch
        {
            'I' => 1,
            'V' => 5,
            'X' => 10,
            'L' => 50,
            'C' => 100,
            'D' => 500,
            'M' => 1000,
            _ => 0
        };

        int result = 0;

        for (int i = 0; i < s.Length; i++)
        {
            if (i + 1 < s.Length && Value(s[i + 1]) > Value(s[i]))
                result -= Value(s[i]);
            else
                result += Value(s[i]);
        }

        return result;
    }
}