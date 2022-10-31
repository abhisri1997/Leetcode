public class Solution {
    public int BinarySearch(int[] nums, int target) 
    {
      int start = 0, end = nums.Count() - 1;
      while(start <= end)
      {
        int mid = (start + end) >> 1;
        if(nums[mid] == target) return mid;
        if( target > nums[mid]) start = mid + 1;
        else end = mid - 1;
      }
      return end + 1;
    }
    public int SearchInsert(int[] nums, int target) {
      return BinarySearch(nums,target);
    }
}