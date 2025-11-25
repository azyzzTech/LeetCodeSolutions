namespace LeetCodeSolutions.Core.Problems.Easy;

public class RomanToIntSolution
{
    public int RomanToInt(string s)
    {
        Dictionary<char, int> romanCharDictionary = new Dictionary<char, int>()
        {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 }
        };

        int result = 0;

        for (int i = 0; i < s.Length; i++)
        {
            int current = romanCharDictionary[s[i]];

            if (i + 1 < s.Length && romanCharDictionary[s[i + 1]] > current)
            {
                result -= current;
            }
            else
            {
                result += current;
            }
        }

        return result;
    }
}