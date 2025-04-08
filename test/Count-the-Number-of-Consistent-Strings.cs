public class Solution {
    public int CountConsistentStrings(string allowed, string[] words) {
        /*
        idea: return the number of the strings that contains only the allowed chars
        start the counter with the words length
        convert the allowed to a set of characters and iterate over words if the word have not allowed character counter--
        */
        HashSet<char>allowedchars=new HashSet<char>();
        for(int i=0;i<allowed.Length;i++){
            allowedchars.Add(allowed[i]);
        }
        int count= words.Length;
        for(int i=0;i<words.Length;i++){
          for(int j=0;j<words[i].Length;j++){
            if(!allowedchars.Contains(words[i][j])){
                count--;
                break;
            }
          }
        }
        return count;
    }
}