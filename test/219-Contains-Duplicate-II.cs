public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        Dictionary<int,int>dic=new Dictionary<int,int>();
        for(int i=0;i<nums.Length;i++){
            if(dic.ContainsKey(nums[i])&&Math.Abs(i-dic[nums[i]])<=k)return true;
            else if(!dic.ContainsKey(nums[i])) dic.Add(nums[i],i);
            else if(dic.ContainsKey(nums[i])&&Math.Abs(i-dic[nums[i]])>k){
                dic[nums[i]]=i;
            }
        }
        return false;

    }
}