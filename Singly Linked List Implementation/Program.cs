namespace Singly_Linked_List_Implementation
{

    class node
    {

        public int value;
        public node nextNode;

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

            // Assign value values
            node1.value = 1;
            node2.value = 2;
            node3.value = 3;

            // Connect nodes
            node1.nextNode = node2;
            node2.nextNode = node3;
            node3.nextNode = null;

            // print the linked list value
            head = node1;

            while (head != null)
            {

                Console.WriteLine(head.value);

                head = head.nextNode;

            }

            Console.ReadKey();

        }
    }
}