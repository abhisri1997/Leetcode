public class Solution {
    public int BinarySearch(int[] a, int start, int end)
    {
      int len = a.Count();
      while(start < end)
      {
        int mid = start + ((end - start) >> 1);
        /* Find first occurence of -ve element */
        if(a[mid] >= 0) start = mid + 1;
        else end = mid;
      }
      return a[start] < 0 ? len - start : 0;
    }
    public int CountNegatives(int[][] A) {
      int row = A.Count();
      int col = A[0].Count();
      int count = 0;
      for(int i = 0; i < row; i++)
      {
        int start = 0;
        int end = col - 1;
        count += BinarySearch(A[i], start, end);
      }
      return count;
    }
}