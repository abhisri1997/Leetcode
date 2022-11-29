public class Solution {
    public int AppendCharacters(string s, string t) {
        int sLen = s.Length;
        int tLen = t.Length;
        int i = 0, j = 0;
      
        while(i < sLen && j < tLen)
        {
          if(s[i] == t[j]) 
          {
            i++;
            j++;
          }
          else
            i++;
        }
        Console.WriteLine(j);
        // StringBuilder sb = new StringBuilder(s);
        // while(j < tLen)
        // {
        //   sb.Append(t[j]);
        // }
        // Console.Write(new string(sb));
        return tLen - j;
    }
}