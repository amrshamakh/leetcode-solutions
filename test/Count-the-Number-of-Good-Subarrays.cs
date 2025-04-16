public class Solution {
    public long CountGood(int[] nums, int k) {
        int pairs=0;
        int l=0;
        long res=0;
        Dictionary<int,int> freq=new Dictionary<int,int>();
        for(int i=0;i<nums.Length;i++){
            if(!freq.ContainsKey(nums[i]))freq.Add(nums[i],0);
            else pairs+=freq[nums[i]];
            freq[nums[i]]++;
            while(pairs>=k){
                res+=nums.Length-i;
                freq[nums[l]]--;
                pairs-=freq[nums[l]];
                l++;
            }
        }
        return res;
    }
}