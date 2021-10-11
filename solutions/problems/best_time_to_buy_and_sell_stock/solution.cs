public class Solution {
    public int MaxProfit(int[] prices) {
        int buy = prices[0];
        int profit = 0;
        int pricesLength = prices.Length;
        for (int i = 1; i < pricesLength; i++) {
            if (buy > prices[i]) {
                buy = prices[i]; // buy when price is minimum
            } else if (prices[i] - buy > profit) { 
                profit = prices[i] - buy; // sell only when we have max profit
            }
        }
        return profit;
    }
}