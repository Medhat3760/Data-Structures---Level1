namespace Doubly_Linked_List_Implementation
{

    class node
    {

        public int value;
        public node next;
        public node prev;

    }

    internal class Program
    {
        static void Main(string[] args)
        {

            node head;

            node node1 = null;
            node node2 = null;
            node node3 = null;

            // allocate 3 nodes in the heap
            node1 = new node();
            node2 = new node();
            node3 = new node();

            // Assign values
            node1.value= 1;
            node2.value= 2;
            node3.value= 3;

            // Connect nodes
            node1.next = node2;
            node1.prev = null;

            node2.next = node3;
            node2.prev = node1;

            node3.next = null;
            node3.prev = node2;

            // print the linked list forward
            Console.WriteLine("Forward traversal:");
            head = node1;

            while (head != null)
            {

                Console.WriteLine(head.value);

                head = head.next;

            }

            Console.WriteLine("Back traversal:");
            head = node3; // start from last node

            while(head != null)
            {

                Console.WriteLine(head.value);

                head = head.prev;

            }

            Console.ReadKey();

        }
    }
}