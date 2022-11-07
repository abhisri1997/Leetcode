public class Solution {
    public int Maximum69Number (int num) {
      char[] str = Convert.ToString(num).ToCharArray();
      int len = str.Length;
      for(int i = 0; i < len; i++)
      {
        if(str[i] == '6')
          {
            str[i] = '9';
            break;
          }
      }
      return int.Parse(string.Join("", str));
    }
}