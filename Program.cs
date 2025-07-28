internal class Program
{
    private static void Main(string[] args)
    {
        var solution = new Solution();

        Console.WriteLine(solution.ContainsDuplicate([1, 2, 3, 1]));
    }
}

public class Solution
{
    public bool ContainsDuplicate(int[] nums)
    {
        var temp = new HashSet<int>();
        foreach (var n in nums)
        {
            if (temp.Contains(n))
                return true;
            temp.Add(n);
        }
        return false;
    }
}
