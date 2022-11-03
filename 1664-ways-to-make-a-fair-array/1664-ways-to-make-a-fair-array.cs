class Solution {
    public int WaysToMakeFair(int[] nums) {
        var evenPrefixSum = new List<int>();
        var oddPrefixSum = new List<int>();
        int len = nums.Count();
        evenPrefixSum.Add(nums[0]);
        oddPrefixSum.Add(0);
        // 6 1 7 4 1
        // 6 6 13 13 14 -- Even Sum
        // 0 1 1 5 5 -- Odd Sum
        for(int i = 1; i < len; i++)
        {
          if((i & 1) == 1)
          {
            evenPrefixSum.Add(evenPrefixSum[i-1]);
            oddPrefixSum.Add(oddPrefixSum[i-1] + nums[i]);
          }
          else
          {
            oddPrefixSum.Add(oddPrefixSum[i-1]);
            evenPrefixSum.Add(evenPrefixSum[i-1] + nums[i]);
          }
        }
      
        int count = 0;
        for(int i = 0; i < len; i++)
        {
          int evenSum = 0, oddSum = 0;
          if(i == 0)
          {
            evenSum = oddPrefixSum[len - 1] - oddPrefixSum[0];
            oddSum = evenPrefixSum[len - 1] - evenPrefixSum[0];
          }
          else if(i == len - 1)
          {
            evenSum = evenPrefixSum[len - 2];
            oddSum = oddPrefixSum[len - 2];
          }
          else
          {
            evenSum = evenPrefixSum[i - 1] + oddPrefixSum[len - 1] - oddPrefixSum[i];
            oddSum = oddPrefixSum[i - 1] + evenPrefixSum[len - 1] - evenPrefixSum[i];
          }
          if(evenSum == oddSum) count++;
        }
      return count;
    }
}