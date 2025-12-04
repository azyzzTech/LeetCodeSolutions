namespace LeetCodeSolutions.Core.Problems.Easy;

public static class LongestCommonPrefixSolution
{
    public static string LongestCommonPrefix(string[] strs)
    {
        string firstWord = strs[0];
        int lengthOfFirst = firstWord.Length;

        for (int i = 0; i < lengthOfFirst; i++)
        {
            char currentChar = firstWord[i];

            for (int j = 1; j < strs.Length; j++)
            {
                if (i == strs[j].Length || strs[j][i] != currentChar)
                {
                    return firstWord.Substring(0, i);
                }
            }
        }

        return firstWord;
    }
}
