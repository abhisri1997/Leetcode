public class Solution {
    public int MaxProfit(int[] prices) {
        int maxProfit = int.MinValue;
        int i = 0, j = 1;
        int len = prices.Count();
        int min_so_far = prices[0];
      
        while(j < len)
        {
          maxProfit = Math.Max(prices[j] - prices[i], maxProfit);
          if(prices[i] > prices[j])
          {
            i++;
          }
          if(min_so_far > prices[j])
          {
            min_so_far = prices[j];
            i = j;
          }
          j++;
        }
        return maxProfit > 0 ? maxProfit : 0;
    }
}