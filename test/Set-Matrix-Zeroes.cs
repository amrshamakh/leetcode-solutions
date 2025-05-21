public class Solution {
    public void SetZeroes(int[][] matrix) {
        //search for zeros if there a zero then 
        // for from 0 to matrix[i].length make them zeros 
        //for for matrix[0][i] to matrix .length 
      
        int m=matrix.Length;
        int n=matrix[0].Length;
        bool[]row =new bool[m];
        bool[]col=new bool[n];
        for(int i=0;i<m;i++){
            for(int j=0;j<n;j++){
                if(matrix[i][j]==0){
                    row[i]=true;
                    col[j]=true;
                }
            }
        }
        for(int i=0;i<m;i++){
            for(int j=0;j<n;j++){
                if(row[i]||col[j]){
                    matrix[i][j]=0;
                }
            }
        }
        
    }
}