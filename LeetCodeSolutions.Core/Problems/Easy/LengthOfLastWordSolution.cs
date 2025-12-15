namespace LeetCodeSolutions.Core.Problems.Easy;

public class LengthOfLastWordSolution
{
    public static int LengthOfLastWord(string s)
    {
        return s.Split(' ', StringSplitOptions.RemoveEmptyEntries).Last().Length;
    }
}
