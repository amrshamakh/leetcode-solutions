public class Solution {
    public IList<string> GetLongestSubsequence(string[] words, int[] groups) {
        int n=groups.Length;
        int state =groups[0];
        IList<string> result=new List<string>{words[0]};
        for(int i=1;i<n;i++){
            if(groups[i]!=state){
                result.Add(words[i]);
                state = groups[i];
            }
        }
        return result;
    }
}