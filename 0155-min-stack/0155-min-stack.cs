public class MinStack {
  
    public class Node {
      public int val;
      public Node next;
      public Node(int val) {
        this.val = val;
      }
    }
    
    Stack<int> st = new Stack<int>();
    Node head;
  
    public MinStack() {
      this.head = null;
    }
  
    public void PushNode(int val) {
      Node temp = new Node(val);
      
      if(head == null)
      {
        head = temp;
      }
      else
      {
        Node swap = head;
        head = temp;
        head.next = swap;
      }
    }
  
    public void PushMinSt(int val) {
      st.Push(val);
    }
    
    public void Push(int val) {
      int min = (head == null && st.Count == 0) ? val : Math.Min(val,st.Peek());
      PushNode(val);
      PushMinSt(min);
    }
    
    public void Pop() {
      st.Pop();
      Node temp = head;
      head = head.next;
      temp = null;
    }
    
    public int Top() {
      return head.val;
    }
    
    public int GetMin() {
      return st.Peek();
    }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(val);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */