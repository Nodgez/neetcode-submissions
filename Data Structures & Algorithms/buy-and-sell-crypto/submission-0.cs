public class Solution {
    public int MaxProfit(int[] prices) {
        int h = 1;
        int l = 0;
        int profit = 0;

        if(prices.Length <= 1)
            return 0;

        for(int i = 1; i < prices.Length;i++)
        {
            var sellPrice = prices[i] - prices[l];

            if(sellPrice > profit)
                profit = sellPrice;

            if(prices[i] < prices[l])
                l = i;
        }

        return profit;
    }
}
