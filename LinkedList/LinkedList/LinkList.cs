using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class Node
    {
        public Node next;
        public Object data;
    }

    public class LinkList
    {
        private Node head;
        private Node current;
        private int length;

        public void Add(Object data)
        {
            Node toAdd = new Node();
            toAdd.data = data;
            Node current = head;
            current.next = toAdd;
        }

        public bool Delete(int Position)
        {
            if (Position == 1)
            {
                head = null;
                current = null;
                return true;
            }

            if (Position > 1 && Position <= length)
            {
                Node tempNode = head;

                Node lastNode = null;
                int count = 0;

                while (tempNode != null)
                {
                    if (count == Position - 1)
                    {
                        lastNode.next = tempNode.next;
                        return true;
                    }
                    count++;

                    lastNode = tempNode;
                    tempNode = tempNode.next;
                }
                

            }
            return false;

        }
    }
}
       
    
