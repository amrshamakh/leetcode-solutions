public class Solution {
    public IList<int> FindWordsContaining(string[] words, char x) {
        /*
        idea get the indices of the word that contain char x
        edge cases:return an empty array if it's not exsited in any word 
        approach i will iterate over the words array and check every word if x exsisted i will add the word index to the 
        list okk lets code.
        */
       List<int> list =new List<int>();
       for(int i=0;i<words.Length;i++){
        if(words[i].Contains(x))list.Add(i);
       } 
       return list;
    }
}