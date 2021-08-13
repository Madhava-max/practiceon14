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
        //public void delete(int position)
        //{
        //    Node temp = head;
        //    if(position==0)
        //    {
        //        head = temp.next;
        //        Console.WriteLine("the element is deleted which is at the start");
        //    }


        //}
        //public void deleteAtlast()
        //{
        //    Node temp = head;
        //    Node front = temp.next;
            
        //    while(front.next!=null)
        //    {
        //        temp = temp.next;
        //        front = front.next;
        //    }
        //    temp.next = null;
        //}
        //public int search(int data)
        //{
        //    int i = 1;
        //    Node temp = head;
        //    while(temp!=null)
        //    {


        //        if (temp.data != data)
        //        {
        //            temp = temp.next;
        //            i++;
        //        }
        //        else
        //        {
        //            Console.WriteLine("the position of the value is " + i);
        //            return i;
        //        }
        //    }
        //    return 0;

        //}
        public void sorting()
        {
            {

            }
        }
        public void searchandinsert(int data1,int data2)
        {
            var newNode = new Node(data2);
            int position = 1;
            int i = 1;
            Node temp = head;
            while (temp != null)
            {


                if (temp.data != data1)
                {
                    temp = temp.next;
                    i++;
                }
                else
                {
                    //    // Console.WriteLine("the position of the value is " + i);
                    //    for (position = 1; position <= i; position++)
                    //    {
                    //        if (position == i)
                    //        {
                    newNode.next = temp.next;
                    temp.next = newNode;
                   // break;


                    //        }
                    //    }

                    //}
                }

            }

        }
    }
}
