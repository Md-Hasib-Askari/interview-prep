namespace Solve;

/// <summary>Non-generic base for discovery and execution.</summary>
public interface IProblem
{
    string Category { get; }
    string Name { get; }
    void Run();
}
