public class Solution {
    public int NumberOfAlternatingGroups(int[] colors, int k) {
        int n=colors.Length;
        int sum=0;
        int[]valid=new int[n];
        int count=0;
        for(int i=0;i<n;i++){
            if(colors[i]!=colors[(i+1)%n])valid[i]=1;
        }
        for(int i=0;i<k-1;i++){
            sum+=valid[i];
        }
      
        for(int i=0;i<n;i++){
           if(sum==k-1)count++;
           sum-=valid[i];
           sum+=valid[(i+k-1)%n];
        }
        return count;
    }
}