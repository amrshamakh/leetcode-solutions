public class Solution {
    public int MostWordsFound(string[] sentences) {
        int max=int.MinValue;
        for(int i=0;i<sentences.Length;i++){
        int count=1;
            for(int j=0;j<sentences[i].Length;j++){
                if(sentences[i][j]==' ')count++;
            }
            max=Math.Max(count,max);
        }
        return max;
    }
}