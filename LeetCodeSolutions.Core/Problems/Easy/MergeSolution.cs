/// <summary>
/// 88. Merge Sorted Array
/// <para>
/// You are given two integer arrays <paramref name="nums1"/> and <paramref name="nums2"/>, sorted in non-decreasing order, 
/// and two integers <paramref name="m"/> and <paramref name="n"/>, representing the number of elements in each array.
/// Merge <paramref name="nums2"/> into <paramref name="nums1"/> as one sorted array in-place.
/// </para>
/// <para>
/// Logic: To avoid using extra space and overwriting elements in <paramref name="nums1"/>, we use a <b>Three-Pointer</b> 
/// approach starting from the <b>end</b> of both arrays. We compare the largest available elements and place 
/// them at the back of <paramref name="nums1"/> (index <c>m + n - 1</c>).
/// </para>
/// <example>
/// Example: nums1 = [1,2,3,0,0,0], m = 3, nums2 = [2,5,6], n = 3 
/// -> Output: [1,2,2,3,5,6]
/// </example>
/// </summary>
/// <param name="nums1">The first sorted array, which has a fixed length of m + n.</param>
/// <param name="m">The number of initial elements in nums1.</param>
/// <param name="nums2">The second sorted array of length n.</param>
/// <param name="n">The number of elements in nums2.</param>
/// <returns>Void. The modification is done in-place within nums1.</returns>
/// <remarks>
/// Time Complexity: $O(m + n)$ - We iterate through both arrays exactly once.
/// Space Complexity: $O(1)$ - No extra space is used as we modify nums1 in-place.
/// </remarks>

namespace LeetCodeSolutions.Core.Problems.Easy;

public class MergeSolution
{
    public static void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        int i = m - 1;
        int j = n - 1;
        int k = m + n - 1;

        while (i >= 0 && j >= 0)
        {
            if (nums1[i] > nums2[j])
            {
                nums1[k--] = nums1[i--];
            }
            else
            {
                nums1[k--] = nums2[j--];
            }
        }

        while (j >= 0)
        {
            nums1[k--] = nums2[j--];
        }
    }
}
