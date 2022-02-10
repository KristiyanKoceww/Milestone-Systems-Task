using System;

namespace Singly_linked_list_of_integers
{
    public class Program
    {
        public static void Main(String[] args)
        {
            // Declare new singly list
            SinglyList list = new();

            // Add nodes to the list
            list.AddNode(1);
            list.AddNode(3);
            list.AddNode(2);
            list.AddNode(5);

            // Test the method

            //1 -> 3 -> 2 -> 5 and M = 0 must return the value of 5 (the value of the last element).
            list.MthFromLastElement(list.head, 0);

            //1-> 3-> 2-> 5 and M = 1 must return the value of 2(the value of the element before the last).
            list.MthFromLastElement(list.head, 1);
        }
    }
}
