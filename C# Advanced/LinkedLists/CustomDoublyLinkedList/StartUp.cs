using System;

namespace CustomDoublyLinkedList
{
    class StartUp
    {
        static void Main(string[] args)
        {
            DoublyLinkedList doublyLinkedList = new DoublyLinkedList();
            Console.WriteLine("Adding....");
            for (int i = 1; i < 6; i++)
            {
                int currElement = i;
                doublyLinkedList.AddFirst(currElement);
            }

            for (int i = 1; i < 6; i++)
            {
                int currElement = i;
                doublyLinkedList.AddLast(currElement);
            }
            Console.WriteLine("Stop Adding....");

            doublyLinkedList.ForEach(n => Console.WriteLine(n));
            Console.WriteLine("Removing....");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(doublyLinkedList.RemoveFirst());
                Console.WriteLine(doublyLinkedList.RemoveLast());
            }
            Console.WriteLine("Stop Removing");

            doublyLinkedList.ForEach(n => Console.WriteLine(n));
            int[] array = doublyLinkedList.ToArray();
            Console.WriteLine(string.Join(" ", array));
        }
    }
}
