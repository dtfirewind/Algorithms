using System;

namespace LinkedList.Domain
{
    public class Node
    {
        public Node next  = null;
        public int data;

        public Node(int data)
        {
           this.data = data;
        }

        public void AppendToTail(int data)
        {
            Node end = new Node(data);
            Node n = this;
            while (n.next != null){
                n = n.next;
            }
            n.next = end;
        }

        public void DeleteNode(int data)
        {
            Node n = this;
            Node prev = n;
            while (n.next != null)
            {
                if(n.next.data == data)
                {
                    n.next = n.next.next;
                }
                n = n.next;
            }

        }
    }
}
