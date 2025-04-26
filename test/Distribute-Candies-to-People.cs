public class Solution {
    public int[] DistributeCandies(int candies, int num_people) {
        int[]result=new int[num_people];
        int i=0;
        //[ 5 2 3 ]
        while(candies>0){
            if(candies<i+1) {
                result[i%num_people]+=candies;
                break;
                }
            result[i%num_people]+=i+1;
            candies-=i+1;
            i++;
        }
        return result;
    }
}