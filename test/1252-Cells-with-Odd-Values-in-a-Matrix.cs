public class Solution {
    public int OddCells(int m, int n, int[][] indices) {
       int[,] result=new int[m,n];
        for(int i=0;i<indices.Length;i++){
         int  row=indices[i][0];
         int  col=indices[i][1];
            for(int j=0;j<n;j++){
                result[row,j]++;
            }
            for(int k=0;k<m;k++){
                result[k,col]++;
            }
          //  indices[i][0]//row
          //indices[i][1]//column
        }
        int count=0;
        for(int i=0;i<m;i++){
            for(int j=0;j<n;j++){
                if(result[i,j]%2==1)count++;
            }
        }
        return count;
    }
}