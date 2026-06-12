using System.Reflection;
using Solve;

// Discover all concrete IProblem implementations
var problemTypes = AppDomain.CurrentDomain.GetAssemblies()
    .SelectMany(a => a.GetTypes())
    .Where(t => t is { IsAbstract: false, IsInterface: false }
                && typeof(IProblem).IsAssignableFrom(t))
    .OrderBy(t => t.Namespace)
    .ThenBy(t => t.Name)
    .ToList();

if (problemTypes.Count == 0)
{
    Console.WriteLine("No problems found.");
    return 0;
}

// Build instances
var problems = problemTypes
    .Select(t => (IProblem)Activator.CreateInstance(t)!)
    .ToList();

// Main loop
while (true)
{
    Console.Clear();
    Console.WriteLine("=== Problem Solver ===\n");

    for (int i = 0; i < problems.Count; i++)
        Console.WriteLine($"  {i + 1,3}. [{problems[i].Category}] {problems[i].Name}");

    Console.Write("\nType a number, name, or category filter (Enter to quit): ");
    var input = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(input))
        return 0;

    // Try numeric selection first
    if (int.TryParse(input.Trim(), out var num) && num >= 1 && num <= problems.Count)
    {
        RunProblem(problems[num - 1]);
        continue;
    }

    // Fuzzy search: case-insensitive substring match on Name or Category
    var filter = input.Trim();
    var matches = problems
        .Select((p, i) => (Index: i, Problem: p))
        .Where(x => x.Problem.Name.Contains(filter, StringComparison.OrdinalIgnoreCase)
                    || x.Problem.Category.Contains(filter, StringComparison.OrdinalIgnoreCase))
        .ToList();

    if (matches.Count == 0)
    {
        Console.WriteLine($"\nNo match for '{filter}'. Press any key...");
        Console.ReadKey(true);
        continue;
    }

    if (matches.Count == 1)
    {
        RunProblem(matches[0].Problem);
        continue;
    }

    // Multiple matches - let user pick
    Console.Clear();
    Console.WriteLine($"=== Matching '{filter}' ===\n");
    for (int i = 0; i < matches.Count; i++)
        Console.WriteLine($"  {i + 1,3}. [{matches[i].Problem.Category}] {matches[i].Problem.Name}");

    Console.Write("\nPick one (or Enter to go back): ");
    var pick = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(pick))
        continue;

    if (int.TryParse(pick.Trim(), out var pickNum) && pickNum >= 1 && pickNum <= matches.Count)
    {
        RunProblem(matches[pickNum - 1].Problem);
        continue;
    }

    Console.WriteLine("\nInvalid selection. Press any key...");
    Console.ReadKey(true);
}

// --- local functions ---

static void RunProblem(IProblem problem)
{
    Console.Clear();
    Console.WriteLine($"=== {problem.Name} [{problem.Category}] ===\n");
    problem.Run();
    Console.Write("\nPress any key to continue...");
    Console.ReadKey(true);
}
