namespace Operations___Insert_At_End
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

            node new_node = new node();

            new_node.value = value;
            new_node.nextNode = head;

            head = new_node;

        }

        static void InsertAtEnd(ref node head, int value)
        {

            node new_node = new node();

            new_node.value = value;
            new_node.nextNode = null;

            if(head == null)
            {
                head = new_node;
                return;
            }

            node lastNode = head;

            while (lastNode.nextNode != null)
            {

                lastNode = lastNode.nextNode;

            }

            lastNode.nextNode = new_node;

        }

        static void PrintList(node head)
        {

            Console.WriteLine();

            while(head != null)
            {

                Console.Write(head.value + " ");

                head = head.nextNode;

            }

        }

        static void Main(string[] args)
        {

            node head = null;

            InsertAtEnd(ref head, 1);
            InsertAtEnd(ref head, 2);
            InsertAtEnd(ref head, 3);
            InsertAtBeginning(ref head, 0);

            PrintList(head);

            Console.ReadKey();

        }
    }
}