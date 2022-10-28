public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        int len = nums.Count();
        Array.Sort(nums, (a,b) => a - b);
        return nums[len - k];
    }
}