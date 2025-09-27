namespace Operations___Delete_Last_Node
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

        static void DeleteLastNode(ref node head)
        {

            if(head == null)
            {
                return;
            }

            if (head.nextNode == null)
            {
                head = null;
                return;
            }

            node current = head;
            node prev = null;

            while(current.nextNode != null)
            {

                prev = current;
                current = current.nextNode;

            }

            prev.nextNode = null;

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

            DeleteLastNode(ref head); 

            PrintList(head);

            Console.ReadKey();

        }
    }
}