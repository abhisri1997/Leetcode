public class BrowserHistory
{

    public class Node
    {
        public string url;
        public Node next, prev;
        public Node(string url)
        {
            this.url = url;
            next = null;
            prev = null;
        }
    }

    Node head, curr;
    public BrowserHistory(string homepage)
    {
        head = new Node(homepage);
        curr = head;
    }

    public void Visit(string url)
    {
        Node node = new Node(url);
        curr.next = node;
        node.prev = curr;
        curr = node;
    }

    public string Back(int steps)
    {
        while (curr.prev != null && steps-- > 0)
        {
            curr = curr.prev;
        }
        return curr.url;
    }

    public string Forward(int steps)
    {
        while (curr.next != null && steps-- > 0)
        {
            curr = curr.next;
        }
        return curr.url;
    }
}