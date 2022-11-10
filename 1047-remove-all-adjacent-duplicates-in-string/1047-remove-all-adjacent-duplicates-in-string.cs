public class Solution {
    public string RemoveDuplicates(string s) {
        var st = new Stack<char>();
        int inLen = s.Length;
      
      
        for(int i = 0; i < inLen; i++)
        {
          
          if(st.Count > 0 && st.Peek() == s[i])
          {
            Console.WriteLine("Popping : " + st.Peek());
            st.Pop();
          }
          else
          {
            st.Push(s[i]);
            Console.WriteLine("Pushed : " + st.Peek());
          }
          
        }
        
        int size = st.Count;
        char[] ansArr = new char[size];
        for(int i = size - 1; i >= 0; i--)
        {
          Console.WriteLine("Current : " + st.Peek());
          ansArr[i] = st.Pop();
        }
        return string.Join("", ansArr);
    }
}