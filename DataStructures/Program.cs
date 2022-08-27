﻿using System;
using DataStructures.Adts;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            //var array = MyList<int>.Of(3, 6, 77);
            //Console.WriteLine(array.ToString());
            //Console.WriteLine(array.Get(1).ToString());
            //array.Set(1, 22).Set(1, 44);
            //Console.WriteLine(array.ToString());

            //Console.WriteLine(array.Insert(1, 22).Insert(2, 55).ToString());

            //Console.WriteLine(array.Remove(1).ToString());


            //var queue = new MyQueue<int>();
            //queue.Add(24).Add(45).Add(33);
            //Console.WriteLine(queue.ToString());

            //Console.WriteLine(queue.Head().ToString());
            //Console.WriteLine(queue.Tail().ToString());

            //Console.WriteLine(queue.Take());

            //Console.WriteLine(queue.ToString());

            ////  24 - 33 - 67 - 12
            //var myStack = new MyStack<int>();
            //myStack.Push(24);
            //myStack.Push(33);
            //myStack.Push(67);
            //myStack.Push(12);

            //Console.WriteLine(myStack.ToString());
            //Console.WriteLine(myStack.Pop());
            //Console.WriteLine(myStack.ToString());

            //Console.WriteLine(myStack.Top());


            // 2 - 48 - 102 - 200
            var list = new MyLinkedList<int>();
            list.AddToEnd(2);
            list.AddToEnd(48);
            list.AddToEnd(102);
            list.AddToEnd(200);

            //Console.WriteLine(list.Get(1));
            Console.WriteLine(list.Get(3));
            //Console.WriteLine(list.Get(4)); // Throws and exception.
            //Console.WriteLine(list.Get(-1)); // Throws and exception.


            //list.Remove(1);
            //Console.WriteLine(list.Get(0));
            //Console.WriteLine(list.Get(1));
            //Console.WriteLine(list.Get(2));





            Console.ReadLine();
        }
    }
}
