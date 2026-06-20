using Solve;

namespace SortandSearch;

// Definition for singly-linked list.
public class ListNode
{
    public int val;
    public ListNode next;

    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}

public class SortListProblem : IProblem
{
    public string Category => "Sort And Search";
    public string Name => "Sort List";

    public ListNode SortList(ListNode head)
    {
        // TODO: Implement
        throw new NotImplementedException();
    }

    public void Run()
    {
        // TODO: Set up test input and call the algorithm
        // var result = SortList(/* args */);
        // Console.WriteLine(result);
        throw new NotImplementedException();
    }
}
