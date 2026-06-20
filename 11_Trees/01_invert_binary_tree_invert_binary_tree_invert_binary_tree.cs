using Solve;

namespace Trees;

// Definition for a binary tree node.
public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;

    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

public class InvertTreeProblem : IProblem
{
    public string Category => "Trees";
    public string Name => "Invert Binary Tree";

    public TreeNode InvertTree(TreeNode root)
    {
        // TODO: Implement
        throw new NotImplementedException();
    }

    public void Run()
    {
        // TODO: Set up test input and call the algorithm
        // var result = InvertTree(/* args */);
        // Console.WriteLine(result);
        throw new NotImplementedException();
    }
}
