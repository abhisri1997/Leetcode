public class Solution {
    public bool BinarySearch(int start, int end,int target)
    {
      if(target == 0) return false;
      if(target == 1) return true;
      while (start <= end)
      {
        int mid = start + ((end - start) >> 1); // 3, 1
        if(mid * mid== target) return true;
        else if(mid > target/mid) end = mid - 1; // 2
        else start = mid + 1;
      }
      return false;
    }
    public bool IsPerfectSquare(int num) {
        return BinarySearch(1, num, num);
    }
}