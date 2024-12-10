namespace Assignment6_3_1
{
    using System;
    using System.Collections.Generic;

    internal class Program
    //You are developing a program to manage a call queue of customers using the Queue  in C#.
    //The program creates a queue of callers and demonstrates the functionality of enqueueing elements into the queue and iterating over the elements and dequeuing.
    {
        static void Main()
        {
            //initialize the queue
            Queue<string> callQueue = new Queue<string>();

            //enqueue incoming numbers
            callQueue.Enqueue("555-2368");//Ghostbusters
            callQueue.Enqueue("555-5678");
            callQueue.Enqueue("555-9101");
            callQueue.Enqueue("555-1121");

            Console.WriteLine("Incoming Calls:");
            DisplayQueue(callQueue);

            //dequeue outgoing numbers
            Console.WriteLine("\nOutgoing Calls:");
            while (callQueue.Count > 0)
            {
                string outgoingNumber = callQueue.Dequeue();
                Console.WriteLine($"Outgoing: {outgoingNumber}");
            }

            //check if queue is empty
            Console.WriteLine("\nQueue after processing all numbers:");
            DisplayQueue(callQueue);
        }

        //method display the queue
        static void DisplayQueue(Queue<string> queue)
        {
            if (queue.Count == 0)
            {
                Console.WriteLine("End of queue");
                return;
            }

            foreach (string number in queue)
            {
                Console.WriteLine(number);
            }
        }
    }
}
