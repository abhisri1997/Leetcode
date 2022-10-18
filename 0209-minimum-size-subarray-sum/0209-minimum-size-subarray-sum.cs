public class Solution {
    public bool SlidingWindow(int[] A, int windowSize, int target)
    {
        int start = 0;
        int end = 0;
        int arrLength = A.Count();
        int sum = 0;
        while(end < arrLength)
        {
            sum += A[end];

            if(end - start + 1 == windowSize)
            {
                if(sum >= target)
                {
                  Console.WriteLine(start + " " + end + " " + sum);
                  return true;
                }
                sum -= A[start];
                start++;
                end++;
            }
            else
            {
                end++;
            }
        }
        return false;
    }
    public int BinarySearch(int[] A, int start, int end, int target)
    {
        int ans = int.MaxValue;
        while(start <= end)
        {
            int mid = start + (end - start)/2;
            int windowSize = mid;
            if(SlidingWindow(A,windowSize,target))
            {
                end = mid - 1;
                ans = Math.Min(ans,windowSize);
            }
            else
            {
                start = mid + 1;
            }
        }
        return ans == int.MaxValue ? 0 : ans;
    }
    public int MinSubArrayLen(int B, int[] A) {
        int maxWindowSize = A.Count();
        int start = 1;
        int end = maxWindowSize;
        return BinarySearch(A, start, end, B);
    }
}