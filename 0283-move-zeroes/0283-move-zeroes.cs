public class Solution {
    public void MoveZeroes(int[] nums) {
        int len = nums.Count();
        int l = 0, r = 0;
        
      while(r < len)
      {
        if(nums[r] != 0)
        {
          int temp = nums[l];
          nums[l] = nums[r];
          nums[r] = temp;
          l++;
        }
        r++;
      }
    }
}