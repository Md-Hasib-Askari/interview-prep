using Solve;

namespace Linkedlists;

// Definition for singly-linked list.
// public class ListNode
// {
//     public int val;
//     public ListNode next;
//
//     public ListNode(int x)
//     {
//         val = x;
//         next = null;
//     }
// }

public class HasCycleProblem : IProblem
{
    public string Category => "Linked Lists";
    public string Name => "Linked List Cycle";

    public bool HasCycle(ListNode head)
    {
        if (head is null)
            return false;

        ListNode slow = head;
        ListNode fast = head;

        while (slow.next != null && fast.next != null && fast.next.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
            if (slow == fast)
            {
                return true;
            }
        }

        return false;
    }

    public void Run()
    {
        // Example 1
        ListNode head = new ListNode(3);
        ListNode node2 = new ListNode(2);
        ListNode node0 = new ListNode(0);
        ListNode node4 = new ListNode(-4);

        head.next = node2;
        node2.next = node0;
        node0.next = node4;
        node4.next = node2; // Creates a cycle

        var result = HasCycle(head);
        Console.WriteLine(result);

        // Example 2
        ListNode e2n1 = new ListNode(1);
        ListNode e2n2 = new ListNode(2);

        e2n1.next = e2n2;
        e2n2.next = e2n1;

        Console.WriteLine(HasCycle(e2n1));

        // Example 3
        ListNode e3n1 = new ListNode(1);

        Console.WriteLine(HasCycle(e3n1));
    }
}
