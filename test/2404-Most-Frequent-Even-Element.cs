public class Solution {
    public int MostFrequentEven(int[] nums) {
        KeyValuePair<int, int> max = new KeyValuePair<int, int>(-1, 0);
        Dictionary<int,int>dic=new Dictionary<int,int>();
        for(int i=0;i<nums.Length;i++){
            if(nums[i]%2==1)continue;
            else{
                if(!dic.ContainsKey(nums[i])) 
                dic.Add(nums[i],0);
                dic[nums[i]]++;
                if(dic[nums[i]]>max.Value) {
                    // max.Key=nums[i];
                    // max.value=dic[nums[i]];
                    max = new KeyValuePair<int, int>(nums[i], dic[nums[i]]);
                    //max.Key=Math.Min(max.Key,nums[i]);
                 }else if(dic[nums[i]]==max.Value) max = new KeyValuePair<int, int>(Math.Min(max.Key,nums[i]),max.Value);
            }
        }
        return max.Key;
    }
}