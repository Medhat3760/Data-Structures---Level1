namespace Operations___Delete_Node
{

    class node
    {
        public int value;
        public node nextNode;
    }

    internal class Program
    {

        static void InsertAtEnd(ref node head, int value)
        {

            node new_node = new node();

            new_node.value = value;
            new_node.nextNode = null;

            if (head == null)
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

        static void DeleteNode(ref node head, int value)
        {

            if (head == null)
            {
                return;
            }

            node current = head;
            node prev = null;

            if (head.value == value)
            {
                head = head.nextNode;
                return;
            }

            while (current != null && current.value != value)
            {

                prev = current;
                current = current.nextNode;

            }

            if (current == null)
            {
                return;
            }

            prev.nextNode = current.nextNode;

        }

        static void PrintList(node head)
        {

            Console.WriteLine();

            while (head != null)
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
            InsertAtEnd(ref head, 4);
            InsertAtEnd(ref head, 5);
            InsertAtEnd(ref head, 6);
            PrintList(head);

            DeleteNode(ref head, 4);

            PrintList(head);

            Console.ReadKey();

        }
    }
}