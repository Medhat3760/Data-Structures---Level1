namespace STL_Stack // Standard Template Library
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // create a stack of ints
            Stack<int> stkNumbers = new Stack<int>();

            // push into stack
            stkNumbers.Push(10);
            stkNumbers.Push(20);
            stkNumbers.Push(30);
            stkNumbers.Push(40);
            stkNumbers.Push(50);

            Console.WriteLine("\nCount = " + stkNumbers.Count);

            // we can access the element by getting the top and popping
            // until the stack is empty
            Console.WriteLine("\nNumbers are:");
            while(stkNumbers.Count>0)
            {

                // print top element
                Console.WriteLine(stkNumbers.Peek());

                // pop top element from stack
                stkNumbers.Pop();

            }

            Console.ReadKey();

        }

        // ال Count 
        //        هي
        //private member
        //بالكلاس وعند اضافه او حذف عنصر بيتم تحديث هذه ال
        //member
        //ويتم استدعائه من خلال ال
        //getter
        //وهذه يفسر ليش ال
        //.Count
        //هي big O(1)
        //لانها فقط بترجع قيمه المتغير ما بتروح تعد من الاول
        //فا هي تعتبر getter

    }
}