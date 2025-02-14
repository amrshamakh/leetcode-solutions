public class Solution {
    public int LengthOfLongestSubstring(string s) {
        HashSet<char>chars=new HashSet<char>();
        int l=0,r=0,res=0;
        for( r=0;r<s.Length;r++){
            while(chars.Contains(s[r])){
                chars.Remove(s[l]);
                l++;
                }
                chars.Add(s[r]);
                res=Math.Max(r-l+1,res);
        }
        return res;
    }
}