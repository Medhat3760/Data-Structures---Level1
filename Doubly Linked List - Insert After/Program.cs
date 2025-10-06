namespace Doubly_Linked_List___Insert_After
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

            if(head != null)
            {
                head.prev = newNode;
            }

            head = newNode;

        }

        static void PrintNodeDetails(Node head)
        {

            if(head.prev != null)
            {
                Console.Write(head.prev.value);
            }
            else
            {
                Console.Write("NULL");
            }

            Console.Write(" <--> " + head.value + " <--> ");

            if(head.next != null)
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

            while(head != null)
            {

                PrintNodeDetails(head);

                head = head.next;

            }

        }

        static void PrintList(Node head)
        {

            Console.Write("NULL <--> ");

            while(head != null)
            {

                Console.Write(head.value + " <--> ");

                head = head.next;

            }

            Console.WriteLine("NULL");

        }

        static Node Find(Node head, int value)
        {

            while(head != null)
            {

                if(head.value == value)
                {
                    return head;
                }

                head = head.next;

            }

            return null;

        }

        static void InsertAfter(Node current, int value)
        {

            Node newNode = new Node();

            newNode.value = value;
            newNode.next = current.next;
            newNode.prev = current;

            if(current.next != null)
            {
                current.next.prev = newNode;
            }

            current.next = newNode;

        }

        static void Main(string[] args)
        {

            Node head = null;

            InsertAtBeginning(ref head, 2);
            InsertAtBeginning(ref head, 1);

            Console.WriteLine("\nLinked List Contenet:");
            PrintList(head);
            PrintListDetails(head);

            Node n1 = Find(head, 1);

            InsertAfter(n1, 500);

            Console.WriteLine("\n\n\nLinked List Contenet after InsertAfter:");
            PrintList(head);
            PrintListDetails(head);

            Console.ReadKey();

        }
    }
}