public class Solution {
    public bool CheckOnesSegment(string s) {
        for(int i=0;i<s.Length-1;i++)
        if(s[i]=='0'&&s[i+1]=='1')return false;
       return true;
    }
   
}