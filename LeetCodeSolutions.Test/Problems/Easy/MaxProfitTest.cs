/// <summary>
/// 121. Best Time to Buy and Sell Stock
/// <para>
/// You are given an array <paramref name="prices"/> where <c>prices[i]</c> is the price of a given stock on the $i^{th}$ day.
/// You want to maximize your profit by choosing a single day to buy one stock and choosing a different day 
/// in the future to sell that stock.
/// </para>
/// <para>
/// Logic: We use a <b>One-Pass (Greedy)</b> approach. We maintain a variable <c>minPrice</c> to track the lowest 
/// price seen so far and a <c>maxProfit</c> variable to track the maximum difference between the current price 
/// and <c>minPrice</c>.
/// </para>
/// <example>
/// Example 1: prices = [7,1,5,3,6,4] -> Output: 5 (Buy on day 2, sell on day 5: 6 - 1 = 5)
/// Example 2: prices = [7,6,4,3,1] -> Output: 0 (No profit possible)
/// </example>
/// </summary>
/// <param name="prices">An array of stock prices where the index represents the day.</param>
/// <returns>The maximum profit possible. If no profit can be achieved, returns 0.</returns>
/// <remarks>
/// Time Complexity: $O(n)$ - We only iterate through the prices array once.
/// Space Complexity: $O(1)$ - Only a few variables are used to track min price and max profit.
/// </remarks>


namespace LeetCodeSolutions.Test.Problems.Easy;

public class MaxProfitTest
{
}
