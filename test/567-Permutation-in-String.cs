public class Solution {
    static bool isAnagram(int[] s1,int[] s2){
        for(int i=0;i<26;i++){
            if(s1[i]!=s2[i])return false;
        }
        return true;
    }
    public bool CheckInclusion(string s1, string s2) {
        int[] arrS1=new int[26];
        int[] arrS2=new int[26];

        for(int i=0;i<s1.Length;i++){
            arrS1[s1[i]-'a']++;
        }
        int l=0,r=0;
        for(r=0;r<s2.Length;r++){
             arrS2[s2[r]-'a']++;
            int window=r-l+1;
            if(window>s1.Length){
                arrS2[s2[l]-'a']--;
                l++;
            }
            if(isAnagram(arrS1,arrS2))return true;
    
        }
        return false;
    }
}