namespace Swap_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // queue container declaration
            Queue<int> myQueue1 = new Queue<int>();
            Queue<int> myQueue2 = new Queue<int>();

            // pushing elements into first queue
            myQueue1.Enqueue(10);
            myQueue1.Enqueue(20);
            myQueue1.Enqueue(30);
            myQueue1.Enqueue(40);

            // pushing elements into 2nd queue
            myQueue2.Enqueue(50);
            myQueue2.Enqueue(60);
            myQueue2.Enqueue(70);
            myQueue2.Enqueue(80);

            // swap elements of queues
            Queue<int> temp = myQueue1;
            myQueue1 = myQueue2;
            myQueue2 = temp;

            // printing the first queue
            Console.Write("\nMy Queue1 = ");
            while (myQueue1.Count > 0)
            {

                Console.Write(myQueue1.Peek() + " ");

                myQueue1.Dequeue();

            }

            // printing the second  queue
            Console.Write("\nMy Queue2 = ");
            while (myQueue2.Count > 0)
            {

                Console.Write(myQueue2.Peek() + " ");

                myQueue2.Dequeue();

            }

            Console.ReadKey();

        }
    }
}