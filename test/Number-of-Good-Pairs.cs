public class Solution {
    public int NumIdenticalPairs(int[] nums) {
        Dictionary<int,int>freq=new Dictionary<int,int>();
        foreach(int num in nums){
            if(!freq.ContainsKey(num))freq.Add(num,0);
            freq[num]++;
        }
        int res=0;
        foreach(int n in freq.Values){
           int val= n*(n-1)/2;
           res+=val;
        }
        return res;
    }
}