/// <summary>
/// 16. 3Sum Closest
/// <para>
/// Given an array <paramref name="nums"/> and a <paramref name="target"/>, find three 
/// integers in the array such that the sum is closest to the target.
/// </para>
/// <para>
/// Logic: Similar to 3Sum, sort the array and use a fixed pointer with two moving pointers. 
/// Update the <c>closestSum</c> whenever a new sum has a smaller absolute difference to the target.
/// </para>
/// <example>
/// Example: nums = [-1,2,1,-4], target = 1 -> Output: 2 (The sum is -1 + 2 + 1 = 2)
/// </example>
/// </summary>
/// <param name="nums">The input integer array.</param>
/// <param name="target">The target sum.</param>
/// <returns>The sum of the three integers closest to the target.</returns>
/// <remarks>
/// Time Complexity: $O(n^2)$ - Sorting followed by a nested two-pointer search.
/// Space Complexity: $O(\log n)$ to $O(n)$ - Space used for sorting.
/// </remarks>

namespace LeetCodeSolutions.Core.Problems.Medium;

public class ThreeSumClosestSolution
{
    public static int ThreeSumClosest(int[] nums, int target)
    {
        int closestSum = nums[0] + nums[1] + nums[2];

        Array.Sort(nums);

        for (int i = 0; i < nums.Length - 2; i++)
        {
            int left = i + 1;
            int right = nums.Length - 1;

            if (i > 0 && nums[i] == nums[i - 1])
                continue;

            int minSum = nums[i] + nums[i + 1] + nums[i + 2];

            if (minSum > target)
            {
                if (Math.Abs(minSum - target) < Math.Abs(closestSum - target))
                {
                    return minSum;
                }
                else
                {
                    return closestSum;
                }
            }

            int maxSum = nums[i] + nums[nums.Length - 1] + nums[nums.Length - 2];

            if (maxSum < target)
            {
                if (Math.Abs(maxSum - target) < Math.Abs(closestSum - target))
                {
                    closestSum = maxSum;
                }
                continue;
            }

            while (left < right)
            {
                int sum = nums[i] + nums[left] + nums[right];

                if (sum == target)
                {
                    return target;
                }
                else
                {
                    if (Math.Abs(sum - target) < Math.Abs(closestSum - target))
                    {
                        closestSum = sum;
                    }

                    if (sum < target)
                    {
                        left++;

                        while (left < right && nums[left] == nums[left - 1])
                            left++;
                    }
                    else
                    {
                        right--;
                        while (left < right && nums[right] == nums[right + 1])
                            right--;
                    }
                }
            }
        }

        return closestSum;
    }
}
