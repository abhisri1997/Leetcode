public class Solution {
    public long MaximumSubarraySum(int[] A, int k) {
        var map = new Dictionary<int,int>();
        int len = A.Count();
        long sum = 0, ans = 0;
        int i = 0, j = 0;
        
        while(j < len)
        {
          sum += A[j];
          if(!map.ContainsKey( A[j] ))
            map.Add(A[j], 1);
          else
            map[A[j]]++;
          if(map.Count == k)
          {
            ans = Math.Max(sum, ans);
          }
          if(j - i + 1 == k)
          {
            sum -= A[i];
            map[A[i]]--;
            if(map[A[i]] == 0) map.Remove(A[i]);
            i++;
          }
          j++;
        }
        return ans;
    }
}