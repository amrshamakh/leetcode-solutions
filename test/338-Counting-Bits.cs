public class Solution {
    public int[] CountBits(int n) {
        int[]result=new int[n+1];
        for(int i=1;i<=n;i++){
            result[i]=result[i/2]+(i&1);
        }
    return result;

    }
}


