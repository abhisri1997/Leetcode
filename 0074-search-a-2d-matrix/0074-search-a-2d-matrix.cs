public class Solution {
    public bool BinarySearch(int[] A, int target, int start, int end)
    {
      while(start <= end)
      {
        int mid = start + ((end - start) >> 1);
        if(A[mid] == target) return true;
        if(target > A[mid]) start = mid + 1;
        else end = mid - 1;
      }
      return false;
    }
    public bool SearchMatrix(int[][] A, int B) {
        int row = A.Count();
        int col = A[0].Count();
        for(int i = 0; i < row; i++)
        {
            int start = 0;
            int end = col - 1;
            if(BinarySearch(A[i], B, start, end))
            {
                return true;
            }
        }
        return false;
    }
}