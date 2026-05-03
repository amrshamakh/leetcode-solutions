1public class Solution {
2    public bool RotateString(string s, string goal) {
3        if(s.Length!=goal.Length)return false;
4        s=s+s;
5      return s.Contains(goal);
6    }
7}