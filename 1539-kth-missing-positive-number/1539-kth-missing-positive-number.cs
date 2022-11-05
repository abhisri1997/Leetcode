public class Solution {
    public int BinarySearch(int[] arr, int start, int end, int k)
    {
      while(start < end)
      {
        int mid = start + ((end - start) >> 1);
        if(arr[mid] - (mid + 1) < k) start = mid + 1;
        else end = mid;
      }
      return end + k;
    }
    public int FindKthPositive(int[] arr, int k) {
        int len = arr.Count();
        int start = 0;
        int end = len;
        return BinarySearch(arr, start, end, k);
    }
}