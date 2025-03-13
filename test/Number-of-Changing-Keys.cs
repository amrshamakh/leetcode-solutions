public class Solution {
    public int CountKeyChanges(string s) {
        int count=0;
    for (int i = 1; i < s.Length; i++) {
        if (!(s[i - 1] == s[i] || s[i - 1] == s[i] + 32 || s[i - 1] == s[i] - 32)) count++;
    }
    return count;
    }
}