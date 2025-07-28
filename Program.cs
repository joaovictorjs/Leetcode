internal class Program
{
    private static void Main(string[] args)
    {
        var solution = new Solution();

        solution.IsAnagram("anagram", "nagaram");
        solution.IsAnagram("car", "rat");
    }
}

public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length)
            return false;

        var map = new Dictionary<char, int>();

        foreach (char c in s)
        {
            if (map.TryGetValue(c, out int value))
            {
                map[c] = ++value;
                continue;
            }

            map[c] = 1;
        }

        foreach (char c in t)
        {
            if (map.ContainsKey(c))
            {
                map[c]--;
                if (map[c] == 0)
                {
                    map.Remove(c);
                }
                continue;
            }

            map[c] = 1;
        }

        return map.Count == 0;
    }
}
