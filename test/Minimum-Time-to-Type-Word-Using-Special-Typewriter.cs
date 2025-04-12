public class Solution {
    public int MinTimeToType(string word) {
        /*
        approach: calc the difference between the the current char and 'a' if it is greater than 13  26- diff and
        if it's <= 13 only increase the counter with diff 
        */
        int count=word.Length;
        int diff=word[0]-'a';
        if(diff>13) count+=26-diff;
        else count+=diff;

        for(int i=1;i<word.Length;i++){
             diff=Math.Abs(word[i]-word[i-1]);
            if(diff>13) count+=26-diff;
            else count+=diff;
        }

        return count;
       
    }
}