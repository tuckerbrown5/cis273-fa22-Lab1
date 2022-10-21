using System.Collections.Generic;

namespace Palindrome;
public class Program
{
    static void Main(string[] args)
    {
        LinkedList<string> linkedList = new LinkedList<string>();

        linkedList.AddLast("xbx");
        linkedList.AddLast("pka");
        linkedList.AddLast("pka");
        linkedList.AddLast("xbx");
    }

    public static bool IsPalindrome<T>(LinkedList<T> linkedList)
    {
        // are the first and last items the same?

        // if so, move toward the middle LinkedListNode<Integer>fast=head.next;
        var head = linkedList.First;
        var tail = linkedList.Last;

        while (head != null)
        {
            if(head == tail)
            {
                return true;
            }
            if(tail == head.Next)
            {
                return head.Value.Equals(tail.Value);
            }
            if (head.Value.Equals(tail.Value))
            {
                head = head.Next;
                tail = tail.Previous;
            }
            else
            {
                return false;
            }
        }
        return true;
    }
}

