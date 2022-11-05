public class Solution {
    public bool IsSubsequence(string A, string B) {
        int len1 = A.Length;
        int len2 = B.Length;
        if(len1 > len2) return false;
        if(len1 == len2)
        {
            return A.CompareTo(B) == 0 ? true : false;
        }
        int i = 0, j = 0;
        while(i < len1 && j < len2)
        {
            if(A[i] == B[j])
            {
                i++;
            }
            j++;
        }
        return i == len1;
    }
}