public class Solution {
    public bool MakeEqual(string[] words) {
        /*
        idea:
        edge cases:
        approach:create array of size 26 to get the freq of each character and iterate over it again to check if the freq of
        each char can be devided into the words 
        */
        int []AlphaArr=new int[26];
        for(int i=0;i<words.Length;i++){
            for(int j=0;j<words[i].Length;j++){
                AlphaArr[words[i][j]-'a']++;
            }
        }
        for(int i=0;i<26;i++){
            if(AlphaArr[i]%words.Length!=0)return false;
        }
        return true;
      
    }
}