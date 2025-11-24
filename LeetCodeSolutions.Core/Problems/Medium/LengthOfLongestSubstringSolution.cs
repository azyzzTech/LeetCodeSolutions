namespace LeetCodeSolutions.Core.Problems.Medium;

public class LengthOfLongestSubstringSolution
{
    public static int LengthOfLongestSubstring(string inputString)
    {
        int maxLength = 0, startPosition = 0;
        Dictionary<char, int> map = new Dictionary<char, int>();

        for (int length = 0; length < inputString.Length; length++)
        {
            if (map.ContainsKey(inputString[length]) && map[inputString[length]] >= startPosition)
            {
                startPosition = map[inputString[length]] + 1;
            }

            map[inputString[length]] = length;
            maxLength = Math.Max(maxLength, length - startPosition + 1);
        }

        return maxLength;
    }
}