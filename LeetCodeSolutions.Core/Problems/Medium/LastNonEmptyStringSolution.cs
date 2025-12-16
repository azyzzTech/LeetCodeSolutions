using System.Text;

namespace LeetCodeSolutions.Core.Problems.Medium;

public class LastNonEmptyStringSolution
{
    public static string LastNonEmptyString(string s)
    {
        int[] freq = new int[26];
        foreach (char c in s)
        {
            freq[c - 'a']++;
        }

        int maxFreq = 0;
        foreach (int f in freq)
        {
            if (f > maxFreq)
            {
                maxFreq = f;
            }
        }

        StringBuilder sb = new StringBuilder();

        for (int i = s.Length - 1; i >= 0; i--)
        {
            char currentChar = s[i];
            int charIndex = currentChar - 'a';

            if (freq[charIndex] == maxFreq)
            {
                sb.Append(currentChar);
                freq[charIndex]--;
            }
        }

        char[] resultChars = sb.ToString().ToCharArray();
        Array.Reverse(resultChars);

        return new string(resultChars);
    }
}
