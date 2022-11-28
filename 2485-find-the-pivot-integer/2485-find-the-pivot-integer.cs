public class Solution {
    public int BS(int start, int end, int[] prefixArr, int[] arr)
    {
      int n = arr.Count();
      int leftSum = 0, rightSum = 0;
      while(start<=end)
      {
        int mid = start + ((end - start) >> 1);
        if(mid - 1 < 0)
        {
          leftSum = prefixArr[mid];
          rightSum = prefixArr[n-1];
        }
        else
        {
            leftSum = prefixArr[mid];
            rightSum = prefixArr[n-1] - prefixArr[mid-1];
        }
        if(leftSum == rightSum) return arr[mid];
        else if(leftSum < rightSum) start = mid + 1;
        else end = mid - 1;
      }
      return -1;
    }
    public int PivotInteger(int n) {
        int[] arr = new int[n];
        int[] prefixArr = new int[n];
        int leftSum = 0, rightSum = 0;
        for(int i = 0; i < n; i++)
        {
          arr[i] = i+1;
        }
        prefixArr[0] = arr[0];
        for(int i = 1; i < n; i++)
        {
          prefixArr[i] = prefixArr[i-1] + arr[i];
        }
        return BS(0, n - 1, prefixArr, arr);
        // for(int i = 0; i < n; i++)
        // {
        //   if(i-1 < 0)
        //   {
        //     leftSum = prefixArr[i];
        //     rightSum = prefixArr[n-1];
        //   }
        //   else
        //   {
        //     leftSum = prefixArr[i];
        //     rightSum = prefixArr[n-1] - prefixArr[i-1];
        //   }
        //   if(leftSum == rightSum) return arr[i];
        // }
        // return -1;
    }
}