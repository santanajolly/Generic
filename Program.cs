using System;
using System.Collections.Generic;

namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            //List
            List<int> list = new List<int>();
            for (int i = 1; i <= 5; i++)
            {
                list.Add(i);
            }
            Console.WriteLine("List:");
            list.ForEach(Console.Write);
            Console.WriteLine("\n");

            //LinkedList
            Console.ForegroundColor = ConsoleColor.Yellow;
            LinkedList<int> linkList = new LinkedList<int>();
            for (int i = 1; i <= 5; i++)
            {
                linkList.AddLast(i);
            }
            Console.WriteLine("LinkedList:");
            foreach (var i in linkList)
            {
                Console.Write(i);
            }
            Console.WriteLine("\n");

            //Queue
            Console.ForegroundColor = ConsoleColor.Red;
            Queue<int> queue = new Queue<int>();
            for (int i = 1; i <= 5; i++)
            {
                queue.Enqueue(i);
            }
            Console.WriteLine("Queue:");
            foreach (var i in queue)
            {
                Console.Write(i);
            }
            Console.WriteLine("\n");

            //Stack
            Console.ForegroundColor = ConsoleColor.Green;
            Stack<int> stack = new Stack<int>();
            for (int i = 1; i <= 5; i++)
            {
                stack.Push(i);
            }
            Console.WriteLine("Stack:");
            foreach (var i in stack)
            {
                Console.Write(i);
            }
            Console.WriteLine("\n");

            //Dictionary
            Console.ForegroundColor = ConsoleColor.White;
            Dictionary<string, int> dictionary = new Dictionary<string, int>()
            {
                {"one", 1 },
                {"two", 2 },
                {"three", 3 },
                {"four", 4 },
                {"five", 5 }
            };
            Console.WriteLine("Dictionary:");

            foreach (var pair in dictionary)
            {
                Console.WriteLine($"{pair.Key}, {pair.Value}");
            }
            Console.WriteLine("\n");

            //SortedList
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            SortedList<string, double> sortlist = new SortedList<string, double>()
            {
                {"One", 1.1 },
                {"Two", 2.1 },
                {"Three", 3.1 },
                {"Four", 4.1 },
                {"Five", 5.1 }
            };
            Console.WriteLine("SortedList:");
            foreach (var pair in sortlist)
            {
                Console.WriteLine($"{pair.Key}, {pair.Value}");
            }
            Console.WriteLine("\n");

            //HashSet
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("HashSet:");
            HashSet<int> hash = new HashSet<int>();
            for (int i = 0; i <= 9; i += 2)
            {
                Console.Write(i);
            }



        }

    }
}


