public class Solution {
    public int FindPeakUsingBinarySearch(int[] arr, int start, int end)
    {
      while(start <= end)
      {
        int mid = start + ((end - start) >> 1);
        if(arr[mid] > arr[mid + 1] && arr[mid] > arr[mid - 1]) return mid;
        else if(arr[mid + 1] > arr[mid]) start = mid + 1;
        else end = mid - 1;
      }
      return -1;
    }
    public int PeakIndexInMountainArray(int[] arr) {
        int len = arr.Count();
        if(arr[0] > arr[1]) return 0;
        if(arr[len - 1] > arr[len - 2]) return len - 1;
        int start = 1;
        int end = len - 2;
        return FindPeakUsingBinarySearch(arr, start, end);
    }
}