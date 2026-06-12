using Solve;

namespace TwoPointers;

public class MaxAreaProblem : IProblem
{
    public string Category => "Two Pointers";
    public string Name => "Max Area";

    public int MaxArea(int[] height)
    {
        int l = 0;
        int r = height.Length - 1;
        int maxA = 0;

        while (l < r)
        {
            int area = Math.Min(height[l], height[r]) * (r - l);
            if (area > maxA)
                maxA = area;

            if (height[l] < height[r])
                l++;
            else
                r--;
        }

        return maxA;
    }

    public void Run()
    {
        int[] input = [1, 8, 6, 2, 5, 4, 8, 3, 7];
        Console.WriteLine($"Max Area: {MaxArea(input)}");
    }
}
