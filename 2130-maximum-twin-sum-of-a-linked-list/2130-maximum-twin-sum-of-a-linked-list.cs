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
    public int PairSum(ListNode head) {
        ListNode temp = head;
        List<int> ls = new List<int>();
      
        while(temp != null)
        {
          ls.Add(temp.val);
          temp = temp.next;
        }
      
        int i = 0, j = ls.Count() - 1;
        int maxSum = int.MinValue;
      
        while(i <= j)
        {
          maxSum = Math.Max(ls[i++] + ls[j--], maxSum);
        }
      return maxSum;
    }
}