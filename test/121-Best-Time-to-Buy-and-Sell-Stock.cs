public class Solution {
    public int MaxProfit(int[] prices) {
        int minP=int.MaxValue,maxP=0;
        for(int i=0;i<prices.Length;i++){
            if(prices[i]<minP)minP=prices[i];
            else maxP=int.Max(maxP,prices[i]-minP);
            
        }
        return maxP;
    }
}