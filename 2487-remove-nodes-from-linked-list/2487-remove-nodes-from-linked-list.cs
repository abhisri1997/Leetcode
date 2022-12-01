/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode RemoveNodes(ListNode head) {
        Stack<int> st = new Stack<int>();
        ListNode temp = head;
        while(temp != null)
        {
          st.Push(temp.val);
          temp = temp.next;
        }
        int len = st.Count;
        int[] arr = new int[len];
        arr[len - 1] = st.Pop();
        int i = len - 1;
        while(st.Count != 0)
        {
          if(st.Peek() >= arr[i])
          {
            arr[i - 1] = st.Peek();
          }
          else
          {
            arr[i-1] = arr[i];
          }
          i--;
          st.Pop();
        }
        List<ListNode> ansNodes = new List<ListNode>();
        temp = head;
        while(temp != null)
        {
          if(temp.val == arr[i])
          {
            ansNodes.Add(temp);
          }
          temp = temp.next;
          i++;
        }
        ListNode ans = ansNodes[0];
        temp = ans;
        for(int k = 1; k < ansNodes.Count(); k++)
        {
          temp.next = ansNodes[k];
          temp = temp.next;
        }
        return ans;
    }
}