public class Solution {
    public string CountAndSay(int n) {
        string s="1";
        for(int i=1;i<n;i++)
         s=NumToRLE(s);
         return s;
        
    }
    public string NumToRLE(string n){
        StringBuilder SB=new StringBuilder();
        int count=1;
        for(int i=1;i<n.Length;i++){
            if(n[i]==n[i-1])count++;
            else {
                SB.Append(count);
                SB.Append(n[i-1]);
                count=1;
            }
        }
        SB.Append(count);
        SB.Append(n[n.Length - 1]);
        return SB.ToString();
    }
}