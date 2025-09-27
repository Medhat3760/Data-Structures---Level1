namespace Operations___Insert_After
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

        // Print the linked list
        static void PrintList(node head)
        {

            Console.WriteLine();

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

                if (head.value == value)
                {
                    return head;
                }

                head = head.nextNode;

            }

            return null;

        }

        static void InsertAfter(node prev_node, int value)
        {

            if(prev_node == null)
            {
                Console.WriteLine("The given previous node cannot be NULL");
                return;
            }

            node new_node = new node();

            new_node.value = value;
            new_node.nextNode = prev_node.nextNode;

            prev_node.nextNode = new_node;

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

            node n1 = Find(head, 2);

            InsertAfter(n1, 500);

            PrintList(head);

            Console.ReadKey();

        }
    }
}