public class Solution {
    public int MaximumNumberOfStringPairs(string[] words) {
        int count = 0;
    HashSet<string> result = new HashSet<string>();
    foreach (string word in words)
    {
        if (result.Contains(new string(new char[] { word[1], word[0] })))
        {
            count++;
        }
        else
        {
            result.Add(word);
        }
    }
    return count;
    }
}