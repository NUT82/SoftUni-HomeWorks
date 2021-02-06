using System;
using System.Collections.Generic;
using System.Text;

namespace CustomDoublyLinkedList
{
    class ListNode
    {
        public ListNode(int element)
        {
            Node = element;
        }

        public int Node { get; set; }

        public ListNode NextNode { get; set; }

        public ListNode PreviousNode { get; set; }

    }
}
