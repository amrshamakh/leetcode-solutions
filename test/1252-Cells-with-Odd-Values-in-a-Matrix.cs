public class Solution {
    public int OddCells(int m, int n, int[][] indices) {
       int[]row=new int[m];
       int[]col=new int[n];
       for(int i=0;i<indices.Length;i++){
        row[indices[i][0]]++;
        col[indices[i][1]]++;
       }
        int count=0;
        for(int i=0;i<m;i++){
            for(int j=0;j<n;j++){
                if((row[i]+col[j])%2==1)count++;
            }
        }
        return count;
    }
}