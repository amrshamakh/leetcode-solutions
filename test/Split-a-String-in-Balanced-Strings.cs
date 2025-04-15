public class Solution {
    public int BalancedStringSplit(string s) {
        int res=0;
        int R=0;
        int L=0;
        for(int i=0;i<s.Length;i++){
            if(s[i]=='R')R++;
            else L++;
            if(R==L)res++;
        }
        return res;
    }
}