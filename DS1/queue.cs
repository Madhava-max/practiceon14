using System;
using System.Collections.Generic;
using System.Text;

namespace DS1
{
    public class queue
    {
        Node head = null;
        internal void enqueue(int data)
        {
            Node node = new Node(data);
            if(head==null)
            {
                head = node;

            }
            else
            {
                Node temp = head;
                while(temp.next!=null)
                {
                    temp = temp.next;

                }
                temp.next = node;
            }
        }
        internal void display()
        {
            Node temp = this.head;
            if(temp==null)
            {
                Console.WriteLine("queue is empty");
                return;
            }
            while(temp!=null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
        }
    }
}
