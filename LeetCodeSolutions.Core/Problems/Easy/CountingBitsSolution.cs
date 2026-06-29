//https://leetcode.com/problems/counting-bits/

namespace LeetCodeSolutions.Core.Problems.Easy;

public class CountingBitsSolution
{
    public int[] CountBits(int n)
    {
        int[] ans = new int[n + 1];
        ans[0] = 0;

        for (int i = 1; i <= n; i++)
        {
            ans[i] = ans[i >> 1] + (i & 1);
        }

        return ans;
    }
}
