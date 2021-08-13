using System;
using System.Collections.Generic;
using System.Text;

namespace DS1
{
    public class linkedlist
    {
     internal Node head;
        internal void Add(int data)
        {
            Node node = new Node(data);
            if(this.head==null)
            {
                this.head = node;
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
            Console.WriteLine("{0} is inserted into linkedlist",node.data);
        }
        internal void Display()
        {
            Node temp = this.head;
            if(temp==null)
            {
                Console.WriteLine("linked list is empty");
                return;
            }
            while(temp!=null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
        }
        public void insertatthemiddle(int position,int data)
        {
            var newNode = new Node(data);
            if (position<0)
            {
                Console.WriteLine("invalid position");

            }
            if(position==0)
            {
                
                newNode.next = this.head;
                head = newNode;
            }
            else
            {
                Node temp = head;
                for(int i=0;i<position;i++)
                {
                    
                    if (position-1==i)
                    {
                        newNode.next = temp.next;
                        temp.next = newNode;
                        break;
                       

                    }
                    temp = temp.next;

                }
                
            }
        }
        public void deleteatfirst()
        {
            Node temp = head;
                head = temp.next;
                Console.WriteLine("the element is deleted which is at the start");
        }
        public void deleteAtlast()
        {
            Node temp = head;
            Node front = temp.next;

            while (front.next != null)
            {
                temp = temp.next;
                front = front.next;
            }
            temp.next = null;
        }
        public void delete(int data)
        {
            var newNode = new Node(data);

            Node temp = head;
            Node front = temp.next;
            while (temp != null)
            {
                if(front.data==data)
                {
                    temp.next = front.next; ; 
                }
                temp = temp.next;
                front = front.next;


            }
        }
        public int search(int data)
        {
            int i = 1;
            Node temp = head;
            while (temp != null)
            {


                if (temp.data != data)
                {
                    temp = temp.next;
                    i++;
                }
                else
                {
                    Console.WriteLine("the position of the value is " + i);
                    return i;
                }
            }
            return 0;

        }
        public void sorting()
        {
            Node temp = head;
           
            //Node dummy;
            while (temp.next != null)
            {
                if (temp.data > temp.next.data)
                {
                    temp.data = (temp.data) + (temp.next.data);
                    temp.next.data= (temp.data) - (temp.next.data);
                    temp.data = (temp.data) - (temp.next.data);
                }
                temp = temp.next;
                
            }
        }
        public void searchandinsert(int data1,int data2)
        {
            var newNode = new Node(data2);
           
            Node temp = head;
            while (temp != null)
            {


                if (temp.data == data1)
                {
                    newNode.next = temp.next;
                    temp.next = newNode;
                    break;
                }
                temp = temp.next;
           

            }

        }
    }
}
