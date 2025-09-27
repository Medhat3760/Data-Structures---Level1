namespace Operations___Insert_At_Beginning
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

            while(head != null)
            {

                Console.Write(head.value + " ");

                head = head.nextNode;

            }

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

            Console.ReadKey();

        }
    }
}