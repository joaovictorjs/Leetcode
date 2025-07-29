internal class Program
{
    private static void Main(string[] args)
    {
        var solution = new Solution();
        System.Console.WriteLine(solution.LongestCommonPrefix(["flower", "flow", "flight"]));
        System.Console.WriteLine(solution.LongestCommonPrefix(["dog", "racecar", "car"]));
    }
}

public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        var minor = strs[0];
        if (minor == string.Empty)
            return minor;
        var common = string.Empty;

        foreach (var s in strs)
        {
            if (s.Length < minor.Length)
                minor = s;
        }

        foreach (var c in minor)
        {
            common += c;

            foreach (var s in strs)
            {
                if (!s.StartsWith(common))
                    return common[..^1];
            }
        }

        return common;
    }
}
