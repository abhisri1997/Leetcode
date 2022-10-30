public class Solution {

    public int[] SingleNumber(int[] nums) {
        int len = nums.Count();
        int xor = 0;
        for(int j = 0; j < len; j++)
        {
          xor ^= nums[j];
        }
        int ans = xor;
        int a = 1;
        int i = 0;
        while(i >= 0){
            if(((ans>>i)&1) > 0){
                break;
            }
            i++;
        }
        a = a << i;
        for(int j = 0; j < len; j++)
        {
          if( (nums[j]&a) == (ans&a) )
          {
                xor ^= nums[j];
          }
        }
        return new int[]{Math.Min(ans^xor,xor),Math.Max(ans^xor,xor)};
    }
}