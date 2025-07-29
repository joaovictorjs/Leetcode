internal class Program
{
    private static void Main(string[] args)
    {
        var solution = new Solution();
        System.Console.WriteLine(solution.WordPattern("abba", "dog cat cat dog"));
        System.Console.WriteLine(solution.WordPattern("aba", "dog cat cat"));
    }
}

public class Solution
{
    public bool WordPattern(string pattern, string s)
    {
        var letters = pattern.ToCharArray();
        var words = s.Split(" ");
        var dict = new Dictionary<char, string>();
        var phrase = string.Empty;
        var lettersSet = new HashSet<char>();
        var wordsSet = new HashSet<string>();

        if (words.Length != letters.Length)
            return false;

        for (int i = 0; i < letters.Length; i++)
        {
            var l = letters[i];
            var w = words[i];
            if (!dict.ContainsKey(l))
                dict.Add(l, w);
            phrase += $" {dict[l]}";
            lettersSet.Add(l);
            wordsSet.Add(w);
        }

        return s == phrase.Trim() && wordsSet.Count == lettersSet.Count;
    }
}
