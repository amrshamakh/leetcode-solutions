public class Solution {
    public int DiagonalSum(int[][] mat) {
       /*
       for(int i=0;i<mat.LENGTH;i++) sum+=mat[i][i]+mat[i][n-i-1];
       [1 2 3 4 5]
       [1 2 3 4 5]
       [1 2 3 4 5]
       [1 2 3 4 5]
       [1 2 3 4 5]

       */ 
       int n=mat.Length;
       int sum=0;
       for(int i=0;i<mat.Length;i++) sum+=mat[i][i]+mat[i][n-i-1];

       if(mat.Length%2==1)return sum-mat[(n-1)/2][(n-1)/2];
       else return sum;

    }
}