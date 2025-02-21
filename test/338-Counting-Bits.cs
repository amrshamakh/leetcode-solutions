public class Solution {
    public int[] CountBits(int n) {
        int[]result=new int[n+1];
        result[0]=0;
        for(int i=1;i<=n;i++){
          int  currentNum=i;
            while(currentNum>0){
                if(currentNum%2==1)result[i]++;
                currentNum/=2;
            }
    }
    return result;
}}