namespace LeetCodeSolutions.Core.Problems.Easy;

public class HaystackNeedleSolution
{
    public static int StrStr(string haystack, string needle)
    {
        return haystack.IndexOf(needle, 0, StringComparison.Ordinal);
    }
}
