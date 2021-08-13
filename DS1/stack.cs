using System;
using System.Collections.Generic;
using System.Text;

namespace DS1
{
    public class stack
    {
        private Node top;
        public stack()
        {
            this.top = null;
        }
        internal void push(int value)
        {
            Node node = new Node(value);
            if(this.top==null)
            {
                node.next = null;
            }
            else
            {
                node.next = this.top;
            }
            this.top = node;
            Console.WriteLine("the value that is pushed   "+value);
        }
        internal void display()
        {
            Node temp = this.top;

            while(temp!=null)
            {
                Console.WriteLine(temp.data + "  ");
                temp = temp.next;
            }
        }
        internal void peek()
        {
            if(top==null)
            {
                Console.WriteLine("stack is empty");
                return;
            }
            Console.WriteLine("{0} is the top of the stack", this.top.data);
        }
        internal void pop()
        {
            if(this.top==null)
            {
                Console.WriteLine("stack is empty");
                return;
            }
            Console.WriteLine("value popped is {0}", this.top.data);
            this.top = this.top.next;
        }
        internal void isempty()
        {
            while(this.top!=null)
            {
                peek();
                pop();
            }
        }
    }
}
