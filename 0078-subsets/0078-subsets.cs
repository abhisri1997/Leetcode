public class Solution {
    public IList<IList<int>> Subsets(int[] A) {
        int length = A.Count();
        IList<IList<int>> ans = new List<IList<int>>();
        int numberOfSubSets = (int)Math.Pow(2, length);
        for (int i = 0; i < numberOfSubSets; i++)
        {
            List<int> subSets = new List<int>();
            int j = 0, n = i;
            while (n > 0)
            {
                if ((n & 1) == 1)
                {
                    subSets.Add(A[j]);
                }
                j++;
                n >>= 1;
            }
            ans.Add(subSets);
        }
        return ans;
    }
}