public class Solution {
    public int BinarySearch(int start, int end,int target)
    {
      if(target == 0) return 0;
      if(target == 1) return 1;
      while (start <= end)
      {
        int mid = start + ((end - start) >> 1); // 84, 41, 20, 9
        if(mid == target/mid) return mid;
        else if(mid > target/mid) end = mid - 1; // 83, 40, 19
        else start = mid + 1;
      }
      return start - 1;
    }
    public int MySqrt(int x) {
        return BinarySearch(0, x, x);
    }
}