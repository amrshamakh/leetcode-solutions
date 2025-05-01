public class Solution {
    public int NumIdenticalPairs(int[] nums) {
        int res=0;
        Dictionary<int,int>freq=new Dictionary<int,int>();
        foreach(int num in nums){
            if(freq.ContainsKey(num)){
            res+=freq[num];
            freq[num]++;
            }else freq.Add(num,1);
        }
        return res;
    }
}