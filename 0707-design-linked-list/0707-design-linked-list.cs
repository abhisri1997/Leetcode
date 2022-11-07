public class Node
{
  public int val;
  public Node next;
    
  public Node(int val)
  {
    this.val = val;
    this.next = null;
  }
}

public class MyLinkedList {
  
  public Node head;
  public int count;
  
  public MyLinkedList() {
    head = null;
    count = 0;
  }
    
  public int Get(int index) {
    // if(index < 0 || index > count) return -1;
    // int i = 0;
    // Node temp = head;
    // while(i < index)
    // {
    //   temp = temp.next;
    //   i++;
    // }
    // return temp.val;
     Node current = head;  
        int i = 0;
        while(current != null && i < index)
        {
            current = current.next;
            i++;        
        }
        
        if(current == null)
        {
            return -1;
        }
        
        // print();
        return current.val;
  }
  
  public void AddAtHead(int val) {
    // if(head == null)
    // {
    //   head.val = val;
    //   head.next = null;
    // }
    // else
    // {
    //   Node temp = new Node(val);
    //   temp.next = head;
    //   head = temp;
    // }
    Node temp = new Node(val);
      temp.next = head;
      head = temp;
    count++;
  }
    // 5 -> 8 -> 2 -> 4 -> 1 -> null
  public void AddAtTail(int val) {
    // if(head == null)
    // {
    //   head.val = val;
    //   head.next = null;
    // }
    // else
    // {
    //   Node tail = head;
    //   Node temp = new Node(val);
    //   int i = count;
    //   while(i > 0)
    //   {
    //     tail = tail.next;
    //     i--;
    //   }
    //   tail.next = temp;
    // }
    Node current = head;
        Node previous = null;
        
        while(current != null)
        {
            previous = current;
            current = current.next;
        }
        
        if(previous == null)
        {
            head = new Node(val);
        }
        else
        {
            previous.next = new Node(val);
        }       

    count++;
  }
    
  public void AddAtIndex(int index, int val) {
    Node current = head;  
        Node previous = null;
        
        if(index < 0)
        {
            return;
        }
        
        if(index == 0)
        {
            var next = head;
            head = new Node(val);            
            head.next = next;
            return;
        }
        
        int i = 0;
        while(current != null && i < index)
        {
            previous = current;
            current = current.next;
            i++;        
        }               
        
        if(i == index)
        {
            var next = current;
            previous.next = new Node(val);
            previous.next.next = next;
        }
        
        // print();
    count++;
  }
    
  public void DeleteAtIndex(int index) {
Node current = head;  
        Node previous = null;
        
        if(index < 0)
        {
            return;
        }
        
        if(index == 0)
        {
           head = head.next;
           return;
        }
        
        int i = 0;
        while(current != null && i < index)
        {
            previous = current;
            current = current.next;
            i++;        
        }               
        
        if(i == index)
        {            
            previous.next = current?.next;            
        }
        

    count--;
  }
}

/**
 * Your MyLinkedList object will be instantiated and called as such:
 * MyLinkedList obj = new MyLinkedList();
 * int param_1 = obj.Get(index);
 * obj.AddAtHead(val);
 * obj.AddAtTail(val);
 * obj.AddAtIndex(index,val);
 * obj.DeleteAtIndex(index);
 */