public class Solution {
    public void Merge(int[] A, int m, int[] B, int n) {
      
        List<int> ans = new List<int>();
        int limitA = m;
        int limitB = B.Count();
        int i = 0, j = 0;

        while(i < limitA && j < limitB)
        {
            if(A[i] <= B[j]) ans.Add(A[i++]);
            else ans.Add(B[j++]);
        }

        if(i < limitA)
        {
            for(; i < limitA; i++)
            {
                ans.Add(A[i]);
            }
        }
        else
        {
            for(; j < limitB; j++)
            {
                ans.Add(B[j]);
            }
        }
      
        for(int k = 0; k < m+n; k++)
        {
          A[k] = ans[k];
        }
    }
}