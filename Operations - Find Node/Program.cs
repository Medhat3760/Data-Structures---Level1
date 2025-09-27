namespace Operations___Find_Node
{

    class node
    {
        public int value;
        public node nextNode;
    }

    internal class Program
    {

        static void InsertAtBeginning(ref node head, int value)
        {
            // Allocate new node
            node new_node = new node();

            // Insert the data
            new_node.value = value;
            new_node.nextNode = head;

            // Move head to new node
            head = new_node;

        }

        static void PrintList(node head)
        {

            while (head != null)
            {

                Console.Write(head.value + " ");

                head = head.nextNode;

            }

        }

        static node Find(node head, int value)
        {

            while (head != null)
            {

                if(head.value == value)
                {
                    return head;
                }

                head = head.nextNode;

            }

            return null;

        }

        static void Main(string[] args)
        {


            node head = null;

            InsertAtBeginning(ref head, 1);
            InsertAtBeginning(ref head, 2);
            InsertAtBeginning(ref head, 3);
            InsertAtBeginning(ref head, 4);
            InsertAtBeginning(ref head, 5);

            PrintList(head);

            node n1 = Find(head, 4);

            if (n1 != null)
            {
                Console.WriteLine("\nNode is found :-)");
            }
            else
            {
                Console.WriteLine("\nNode is Not found :-(");
            }

            Console.ReadKey();

        }
    }
}