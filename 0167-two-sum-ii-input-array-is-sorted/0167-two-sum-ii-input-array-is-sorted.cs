public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int len = numbers.Count();
        int start = 0;
        int end = len - 1;
        
        while(start < end)
        {
          int sum = numbers[start] + numbers[end];
          if(sum == target)
          {
            return new int[]{start + 1, end + 1};
          }
          else if(sum > target) end--;
          else start++;
        }
      return new int[]{-1};
    }
}