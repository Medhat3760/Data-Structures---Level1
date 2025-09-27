using MyLib;
namespace Stack_Swap
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // stack container declaration
            Stack<int> myStack1 = new Stack<int>(); 
            Stack<int> myStack2 = new Stack<int>();

            // pushing elements into first stack
            myStack1.Push(10);
            myStack1.Push(20);
            myStack1.Push(30);
            myStack1.Push(40);
            myStack1.Push(50);

            // pushing elements into 2nd stack
            myStack2.Push(60);
            myStack2.Push(70);
            myStack2.Push(80);
            myStack2.Push(90);
            myStack2.Push(100);

            // swap stacks(just swap the references)
            clsUtil.Swap(ref myStack1, ref myStack2);

            // printing the first stack
            Console.Write("\nMy Stack1 = ");
            while(myStack1.Count > 0)
            {

                Console.Write(myStack1.Peek() + " ");

                myStack1.Pop();

            }

            // printing the second stack
            Console.Write("\nMy Stack2 = ");
            while(myStack2.Count > 0)
            {

                Console.Write(myStack2.Peek() + " ");

                myStack2.Pop();

            }

            Console.ReadKey();

        }
    }
}