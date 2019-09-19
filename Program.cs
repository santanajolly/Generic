using System.Collections.Generic;

namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            //List
            List<int> list = new List<int>();
            for (int i = 1; i <= 5; i++)
            {
                list.Add(i);
            }

            //LinkedList
            LinkedList<int> linkList = new LinkedList<int>();
            for (int i = 1; i <= 5; i++)
            {
                linkList.AddLast(i);
            }

            //Queue
            Queue<int> queue = new Queue<int>();
            for (int i = 1; i <= 5; i++)
            {
                queue.Enqueue(i);
            }
        }

    }
}


