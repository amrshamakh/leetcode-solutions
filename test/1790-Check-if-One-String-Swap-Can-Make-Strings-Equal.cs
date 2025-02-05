public class Solution {
    public bool AreAlmostEqual(string s1, string s2) {
        if(s1.Length!=s2.Length)return false;
        if(s1==s2)return true;
        int[]diff=new int[2];
        int n=s1.Length;
        int count =0;
        for(int i=0;i<n;i++){
            if(s1[i]!=s2[i]){
                if(count==2)return false;
                diff[count]=i;
                count++;
                }
            
        }
        if(s1[diff[0]]==s2[diff[1]]&&s1[diff[1]]==s2[diff[0]])return true;
        return false;
    }
}