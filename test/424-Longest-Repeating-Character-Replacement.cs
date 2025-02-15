public class Solution {
    public int CharacterReplacement(string s, int k) {
        int[]chars=new int[26];
        int max=0;
        int r=0,l=0;
        int maxCount=0;
        for(r=0;r<s.Length;r++){
            chars[s[r]-'A']++;
            int current_count=chars[s[r]-'A'];
            maxCount=Math.Max(current_count,maxCount);
            while(r-l+1-maxCount>k){
                chars[s[l]-'A']--;
                l++;
            }
            max=Math.Max(r-l+1,max);
        }
        return max;
    }
}