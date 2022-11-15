public class Solution {
    public bool IsValid(string A) {
        var st = new Stack<char>();
            int len = A.Length;
            var balancedParentheses = new Dictionary<char, char>();
            balancedParentheses.Add('{', '}'); balancedParentheses.Add('[', ']');
            balancedParentheses.Add('(', ')');

            foreach (char ch in A)
            {
                if (balancedParentheses.ContainsKey(ch))
                {
                    st.Push(ch);
                }
                else if (st.Count > 0 && balancedParentheses[st.Peek()] == ch)
                {
                    st.Pop();
                }
                else
                {
                    return false;
                }
            }
            return st.Count == 0 ? true : false;
    }
}