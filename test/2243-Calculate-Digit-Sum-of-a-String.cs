public class Solution {
    public string DigitSum(string s, int k) {
        int j=0;
        while(s.Length>k){
            int count=0;
            string result="";
            int currentS=0;
        for(int i=0;i<s.Length;i++){
            currentS+=s[i]-'0';
            count++;
            if(count==k||i==s.Length-1){
               result+=currentS.ToString();
               currentS=0;
               count=0;
            }
        }
        s=result;
    }
        return s;
}
  
}