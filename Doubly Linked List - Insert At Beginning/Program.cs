namespace Doubly_Linked_List___Insert_At_Beginning
{
    class Node
    {

        public int value;
        public Node next;
        public Node prev;

    }

    internal class Program
    {

        static void InsertAtBeginning(ref Node head, int value)
        {

            Node newNode = new Node();
            newNode.value = value;
            newNode.next = head;
            newNode.prev = null;

            if (head != null)
            {

                head.prev = newNode;

            }

            head = newNode;

        }

        static void PrintList(Node head)
        {

            Console.Write("Null <--> ");

            while (head != null)
            {

                Console.Write(head.value + " <--> ");

                head = head.next;


            }

            Console.WriteLine("NULL");

        }

        static void PrintNodeDetails(Node head)
        {

            if (head.prev != null)
            {
                Console.Write(head.prev.value);
            }
            else
            {
                Console.Write("NULL");
            }

            Console.Write(" <--> " + head.value + " <--> ");

            if (head.next != null)
            {
                Console.WriteLine(head.next.value);
            }
            else
            {
                Console.WriteLine("NULL");
            }

        }

        static void PrintListDetails(Node head)
        {

            Console.WriteLine();

            while (head != null)
            {

                PrintNodeDetails(head);

                head = head.next;
            }

        }

        static void Main(string[] args)
        {

            Node head = null;

            InsertAtBeginning(ref head, 5);
            InsertAtBeginning(ref head, 4);
            InsertAtBeginning(ref head, 3);
            InsertAtBeginning(ref head, 2);
            InsertAtBeginning(ref head, 1);

            Console.WriteLine("\nLinked List Contenet:");

            PrintList(head);

            PrintListDetails(head);

            Console.ReadKey();

        }
    }

}