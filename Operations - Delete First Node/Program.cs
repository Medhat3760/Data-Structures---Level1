namespace Operations___Delete_First_Node
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

        static void DeleteFirstNode(ref node head)
        {

            if(head==null)
            {
                return;
            }

            head = head.nextNode;

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

            DeleteFirstNode(ref head);
            DeleteFirstNode(ref head);
            DeleteFirstNode(ref head);

            PrintList(head);

            Console.ReadKey();

        }
    }
}