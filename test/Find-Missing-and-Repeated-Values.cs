public class Solution {
    public int[] FindMissingAndRepeatedValues(int[][] grid) {
        int n=grid.Length;
        int a=0,b=0;
        HashSet<int> set=new HashSet<int>();
        for(int i=0;i<n;i++){
            for(int j=0;j<n;j++){
                if(set.Contains(grid[i][j]))a=grid[i][j];
                else set.Add(grid[i][j]);
            }
        }
        for(int i=1;i<=n*n;i++){
            if(!set.Contains(i))b=i;
        }
        return new int[]{a,b};
    }
}