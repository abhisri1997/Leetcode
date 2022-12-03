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
    public ListNode reverseLL(ListNode curr) 
    {
      ListNode prev = null;
      
      while(curr != null)
      {
        ListNode temp = curr.next;
        curr.next = prev;
        prev = curr;
        curr = temp;
      }
      return prev;
    }
    public ListNode findMidNode(ListNode head) 
    {
      ListNode slow = head;
      ListNode fast = head;
        
      while(fast != null && fast.next != null)
      {
        slow = slow.next;
        fast = fast.next.next;
      }
      return slow;
    }
    public int PairSum(ListNode head) 
    {
        ListNode mid = findMidNode(head);
        ListNode tail = reverseLL(mid);
        ListNode start = head;
        ListNode end = tail;
        int maxSum = 0;
      
        while(end != null)
        {
          int sum = start.val + end.val;
          maxSum = Math.Max(sum,maxSum);
          end = end.next;
          start = start.next;
        }
      return maxSum;
    }
}