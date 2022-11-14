public class Solution {  
  public int gcd(int a, int b) {
        if (a == 0)
            return b;
        return gcd(b % a, a);
  }
     
  public int findLCM(int a, int b) {
        return (a / gcd(a, b)) * b;
  }
  
  public int SubarrayLCM(int[] nums, int k) {
    int len = nums.Length;
    int ans = 0;
    for(int i = 0; i < len; i++)
    {
      int lcm = nums[i];
      for(int j = i; j < len; j++)
      {
        lcm = findLCM(lcm,nums[j]);
        if(lcm == k) ans++;
      }
    }
    return ans;
  }
}