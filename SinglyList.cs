using System;

namespace Singly_linked_list_of_integers
{

    public class SinglyList : ISinglyList
    {
        // this is head of the SinglyList
        public Node head;

        public void AddNode(int data)
        {
          
            // We create node and set the new data
            Node node = new Node(data);


            // We check if head is null and set the new node as head
            if (head == null)
            {
                head = new Node(data);
                return;
            }

            // This node will be last node so we need to make next null
            node.next = null;

            // Traverse until the last node
            Node last = head;
            while (last.next != null)
            {
                last = last.next;
            }

            // Change the next of last node
            last.next = node;

        }
        public void MthFromLastElement(Node head, int m)
        {
            // We declare two pointers
            Node p1 = head;
            Node p2 = head;

            // Looping until we reach the end. For the last node "next" will be NULL
            while (p1.next != null)
            {
                if (m > 0)
                {
                    // using "next" only on first pointer when input "m" is greater than 0
                    p1 = p1.next;
                    m--;
                }
                else
                {
                    p1 = p1.next;
                    p2 = p2.next;
                }
            }

            Console.WriteLine(p2.data);
        }
    }
}

