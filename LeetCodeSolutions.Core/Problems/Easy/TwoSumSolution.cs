namespace LeetCodeSolutions.Core.Problems.Easy;

public class TwoSumSolution
{
    public static int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> twoSumDictionary = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int odd = target - nums[i];

            if (twoSumDictionary.ContainsKey(odd))
            {
                return new int[] { twoSumDictionary[odd], i };
            }

            twoSumDictionary[nums[i]] = i;
        }

        return Array.Empty<int>();
    }
}