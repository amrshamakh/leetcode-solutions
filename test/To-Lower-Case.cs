public class Solution {
    public string ToLowerCase(string s) {
        StringBuilder sb = new StringBuilder();
    
        
        for (int i = 0; i < s.Length; i++)
        {
            if (char.IsUpper(s[i])) sb.Append((char)(s[i] + 32));
            else sb.Append(s[i]);
        }
        return sb.ToString();
    }
}