public class Solution {
    public int NumberOfAlternatingGroups(int[] colors, int k) {
        int n=colors.Length;
        int result=0,count=1;
        for(int i=0;i<n+k-2;i++){
            if(colors[i%n]!=colors[(i+1)%n])count++;
            else count=1;
            if(count>=k)result++;
        }
    return result;
    }
}