public class Solution {
    public int Merge(int[] A, int start, int mid, int end)
    {
        List<int> helperArr = new List<int>();
        int i = start, j = mid;
        int count = 0;

        while(i < mid && j <= end)
        {
            if(A[i] <= A[j]) helperArr.Add(A[i++]);
            else 
            {
                helperArr.Add(A[j++]);
                count += mid - i;
            }
        }

        while(i < mid)
        {
            helperArr.Add(A[i++]);
        }

        while(j <= end)
        {
            helperArr.Add(A[j++]);
        }

        int k = 0;
        for(int l = start; l <= end; l++)
        {
            A[l] = helperArr[k++];
        }
        return count;
    }
    public int MergeSort(int[] A, int start, int end)
    {
        if(start >= end) return 0;

        int mid = start + ((end - start) >> 1);

        int x = MergeSort(A, start, mid);
        int y = MergeSort(A, mid + 1, end);
        int z = Merge(A,start, mid + 1, end);
        return x + y + z;
    }
    public bool IsIdealPermutation(int[] nums) {
        int len = nums.Count();
        int localCount = 0;
        for(int i = 0; i < len - 1; i++)
        {
          if(nums[i] > nums[i + 1]) localCount++;
        }
        int globalCount = MergeSort(nums, 0, len - 1);
        return localCount == globalCount;
    }
}