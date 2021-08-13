using System;

namespace DS1
{
    class Program
    {
        static void Main(string[] args)
        {
            linkedlist list = new linkedlist();


            //first Uc
            //list.Add(56);
            //list.Add(30);
            //list.Add(70);
            //list.Display();


            //SECOND USE CASE
            //list.Add(70);
            //list.Add(30);
            //list.Add(56);
            //list.Display();

            //fourth use case
            //list.Add(70);
            //list.Add(30);
            //list.Add(56);
            // list.insertatthemiddle(3, 40);

            // list.Display();

            //fifth use case
            //list.Add(70);
            //list.Add(30);
            //list.Add(56);
            //list.delete(0);
            //list.Display();

            //sixth use case
            //list.Add(70);
            //list.Add(30);
            //list.Add(56);
            //list.deleteAtlast();
            //list.Display();

            //SEVENTH USE CASE
            //list.Add(70);
            //list.Add(30);
            //list.Add(56);
            //int a=list.search(70);
            //int b=list.search(30);
            //int c=list.search(56);
            //if (b == 0)
            //{
            //    Console.WriteLine("element not found");
            //}
            //else
            //{
            //    Console.WriteLine("the element of the position  " + b+"  "+a+"  "+c);
            //}
            //list.Display();


            //EIGHTH USE CASE
            list.Add(70);
            list.Add(30);
            list.Add(56);
            list.Display();
            list.searchandinsert(30, 40);
            list.Display();
            



            //stack list = new stack();
            //list.push(60);
            //list.push(35);

        }
    }
}
