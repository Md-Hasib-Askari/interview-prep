using Solve;

namespace HashMapsSets;

public class PairSumUnsorted : IProblem
{
    public string Category => "Hash Maps & Sets";
    public string Name => "Pair Sum Unsorted";

    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> map = [];

        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];
            if (map.TryGetValue(complement, out int complementIndex))
            {
                return [complementIndex, i];
            }
            map[nums[i]] = i;
        }
        return [];
    }

    public void Run()
    {
        var result = TwoSum([2, 7, 11, 15], 9);
        Console.WriteLine($"Pair Sum Unsorted: [{string.Join(", ", result)}]");
    }
}
