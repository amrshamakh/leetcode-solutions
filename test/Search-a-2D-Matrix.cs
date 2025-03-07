public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int l=0,r=matrix.Length-1;
        while(l<=r){
            int mid=(l+r)/2;
            if(target>=matrix[mid][0]&&target<=matrix[mid][matrix[mid].Length-1]){
                int left=0, right=matrix[mid].Length-1;
                while(left<=right){
                    int m=(left+right)/2;
                    if(matrix[mid][m]==target)return true;
                    else if(target>matrix[mid][m])left=m+1;
                    else right=m-1;
                }
                return false;
            }
            if(target>matrix[mid][matrix[mid].Length-1])l=mid+1;
            else if(target<matrix[mid][0])r=mid-1;
        }
        return false;
    }
}