public class Solution {
  
    public int findFirstOccurence(int[] nums, int start, int end, int target)
    {
      while(start < end)
      {
        int mid = start + ((end - start) >> 1);
        if(nums[mid] < target) start = mid + 1;
        else end = mid;
      }
      return start;
    }
    // 0 1 2 3 4
    // 2 3 3 3 3
    // target 3, 4
    public int[] SearchRange(int[] nums, int target) {
        int len = nums.Count() - 1;
        int[] ans = new int[]{-1,-1};
        if(len < 0) return ans;
        int firstOccurence = findFirstOccurence(nums, 0, len, target);
        if(nums[firstOccurence] != target) return ans;
        int lastOccurence = findFirstOccurence(nums, 0, len, target + 1);
        if(nums[lastOccurence] != target) lastOccurence--;
        ans[0] = firstOccurence;
        ans[1] = lastOccurence;
        return ans;
    }
}