/// <summary>
/// 27. Remove Element
/// <para>
/// Given an integer array <paramref name="nums"/> and an integer <paramref name="val"/>, 
/// remove all occurrences of <paramref name="val"/> in <paramref name="nums"/> in-place. 
/// The order of the elements may be changed.
/// </para>
/// <para>
/// Logic: Use a pointer <c>k</c> to keep track of the position where the next "non-val" 
/// element should be placed. Iterate through the array; if the current element is not 
/// equal to <paramref name="val"/>, move it to index <c>k</c> and increment <c>k</c>.
/// </para>
/// <example>
/// Example: nums = [3,2,2,3], val = 3 -> Output: 2, nums = [2,2,_,_]
/// </example>
/// </summary>
/// <param name="nums">The integer array to modify.</param>
/// <param name="val">The value to be removed from the array.</param>
/// <returns>The number of elements in <paramref name="nums"/> which are not equal to <paramref name="val"/>.</returns>
/// <remarks>
/// Time Complexity: $O(n)$ - Single pass through the array.
/// Space Complexity: $O(1)$ - Modification is done in-place.
/// </remarks>

namespace LeetCodeSolutions.Core.Problems.Easy;

public class RemoveElementSolution
{
    public static int RemoveElement(int[] nums, int val)
    {
        int k = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != val)
            {
                nums[k] = nums[i];
                k++;
            }
        }

        return k;
    }
}
