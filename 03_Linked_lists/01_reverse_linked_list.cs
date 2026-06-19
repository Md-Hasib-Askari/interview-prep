using Solve;

namespace Linkedlists;

// Definition for singly-linked list.
public class ListNode(int val = 0, ListNode next = null)
{
    public int val = val;
    public ListNode? next = next;
}

public class ReverseListProblem : IProblem
{
    public string Category => "Linked Lists";
    public string Name => "Reverse Linked List";

    public ListNode? ReverseList(ListNode head)
    {
        ListNode? prev = null;
        ListNode curr = head;

        while (curr != null)
        {
            ListNode? next = curr.next;
            curr.next = prev;
            prev = curr;
            curr = next;
        }
        return prev;
    }

    public void Run()
    {
        ListNode n1 = new() { val = 1 };
        ListNode n2 = new() { val = 2 };
        ListNode n3 = new() { val = 3 };
        ListNode n4 = new() { val = 4 };
        ListNode n5 = new() { val = 5 };
        n1.next = n2;
        n2.next = n3;
        n3.next = n4;
        n4.next = n5;

        var result = ReverseList(n1);
        Console.WriteLine(result);
    }
}
