internal class Program
{
    private static void Main(string[] args)
    {
        var solution = new Solution();
        var result = solution.Intersection([1, 2, 2, 1], [2, 2]);
        foreach (var item in result)
        {
            Console.WriteLine(item);
        }
    }
}

public class Solution
{
    public int[] Intersection(int[] nums1, int[] nums2)
    {
        var intersection = Array.Empty<int>();
        foreach (var item in nums1)
        {
            if (nums2.Contains(item) && !intersection.Contains(item))
                intersection = [.. intersection, item];
        }
        return intersection;
    }
}
