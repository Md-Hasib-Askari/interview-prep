using Solve;

namespace Graphs;

// Definition for a Node.
public class Node
{
    public int val;
    public IList<Node> neighbors;

    public Node()
    {
        val = 0;
        neighbors = new List<Node>();
    }

    public Node(int _val)
    {
        val = _val;
        neighbors = new List<Node>();
    }

    public Node(int _val, List<Node> _neighbors)
    {
        val = _val;
        neighbors = _neighbors;
    }
}

public class CloneGraphProblem : IProblem
{
    public string Category => "Graphs";
    public string Name => "Clone Graph";

    public Node CloneGraph(Node node)
    {
        // TODO: Implement
        throw new NotImplementedException();
    }

    public void Run()
    {
        // TODO: Set up test input and call the algorithm
        // var result = CloneGraph(/* args */);
        // Console.WriteLine(result);
        throw new NotImplementedException();
    }
}
