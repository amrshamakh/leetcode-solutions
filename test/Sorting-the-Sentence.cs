public class Solution {
public string SortSentence(string s) {
        /*
            ex: sentence4 a3 is2 This1
            - split the givven string
            - make a result array with the length of splitted array
            - foreach word in splitted array
              - result[word[wordLength -1] - 1] = word [Without last char]
            ---------
            - make a result array of length 9 (max possible number of wrods)
            - loop over s and put each word in the pos equivlent to its last char (num)
        */
        var sortedWords = new string[9];
        var word = new StringBuilder();
        for(int i  = 0; i < s.Length; i++){
            if(char.IsDigit(s[i])){
                sortedWords[(s[i] - '0') - 1] = word.ToString();
                word.Clear();
            }
            else if( s[i] == ' ') continue;
            else word.Append(s[i]);
        }
       
        var SortedSentence = new StringBuilder();
        foreach (var w in sortedWords){
            if(!string.IsNullOrEmpty(w)){
                SortedSentence.Append(w);
                SortedSentence.Append(' ');
            }
        }
        SortedSentence.Remove(SortedSentence.Length - 1, 1);
        return SortedSentence.ToString();
    }
}