namespace STL_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Queue container declaration
            Queue<int> myQueue = new Queue<int>();

            // pushing elements into queue
            myQueue.Enqueue(10);
            myQueue.Enqueue(20);
            myQueue.Enqueue(30);
            myQueue.Enqueue(40);

            Console.WriteLine("\nCount: " + myQueue.Count);
            Console.WriteLine("Front : " + myQueue.Peek());
            // علشان تجيب آخر عنصر (Back):
            // Queue<T> مالهاش Back جاهزة، لازم نجيب آخر عنصر يدوي
            Console.WriteLine("Back  : " + (myQueue.Count > 0 ? myQueue.ToArray()[myQueue.Count - 1] : 0));

            Console.Write("\nMy Queue = ");
            while (myQueue.Count > 0)
            {

                Console.Write(myQueue.Peek() + " ");

                myQueue.Dequeue(); // remove front

            }

            Console.ReadKey();

        }
    }
}