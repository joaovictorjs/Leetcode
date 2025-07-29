internal class Program
{
    private static void Main(string[] args)
    {
        var solution = new Solution();

        Console.WriteLine(solution.MissingNumber([3, 0, 1]));
    }
}

public class Solution
{
    public int MissingNumber(int[] nums)
    {
        var length = nums.Length;
        var sum = nums.Sum();
        static int consecutiveSum(int accumulator, int index, int target)
        {
            if (index > target)
                return accumulator;
            return consecutiveSum(accumulator += index++, index, target);
        }
        var expectedSum = consecutiveSum(0, 0, length);
        return expectedSum - sum;
    }
}
