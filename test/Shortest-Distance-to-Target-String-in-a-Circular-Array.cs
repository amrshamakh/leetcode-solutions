public class Solution {
    public int ClosestTarget(string[] words, string target, int startIndex) {
        int n=words.Length,forward=startIndex,backward=startIndex;
        for(int i=0;i<n;i++){
             forward = (startIndex + i) % n;
             backward = (startIndex - i + n) % n;
             if(words[forward]==target||words[backward]==target)return i;
        }
        return -1;
    }
}