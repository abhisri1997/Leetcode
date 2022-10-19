public class Solution {
  public bool comparator(string word1, string word2, Dictionary<char,int> map)
    {
        int i = 0;
        int len1 = word1.Length;
        int j = 0;
        int len2 = word2.Length;
        int comparatorValue = 0;

        // Console.WriteLine(word1 + " " + word2);

        while(i < len1 && j < len2)
        {
            comparatorValue = map[word1[i]] - map[word2[j]];
            // Console.Write(word1[i] + " " + word2[j] + " " + comparatorValue);
            // Console.WriteLine();
            if(comparatorValue < 0) return true;
            else if(comparatorValue > 0) return false;
            i++;
            j++;
        }

        // Console.WriteLine();

        return len1 > len2 ? false : true;
    }
    public bool IsAlienSorted(string[] A, string B) {
        Dictionary<char,int> map = new Dictionary<char,int>();
        for(int i = 0; i < B.Length; i++)
        {
            map.Add(B[i],i);
        }
        int len = A.Count();
        for(int i = 0; i < len - 1; i++)
        {
            if(!comparator(A[i],A[i+1],map))
            {
                return false;
            }
        }
        return true;
    }
}