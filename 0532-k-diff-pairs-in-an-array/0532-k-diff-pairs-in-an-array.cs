public class Solution {
    public int FindPairs(int[] A, int B) {
        int len = A.Count();
        int ans = 0;
        int start = 0;
        int end = 1;
        Array.Sort(A, (a,b) => {
            if(a > b) return 1;
            if(a < b) return -1;
            return 0;
        });
        while(end < len)
        {
            int diff = A[end] - A[start];
            if( diff < B || start == end ) end++;
            else if( diff > B ) start++;
            else
            {
                ans++;
                start++;
                while(start < len && A[start] == A[start - 1]) start++;
                end = Math.Max(end + 1, start + 1);
            }
        }
        return ans;
    }
}