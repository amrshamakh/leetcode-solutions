public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Hashtable myHash=new Hashtable();
        for(int i=0;i<nums.Length;i++){
            int complement=target-nums[i];
           if(myHash.ContainsKey(complement)) return new int[]{(int)myHash[complement],i};
           if(!myHash.ContainsKey(nums[i])) myHash.Add(nums[i],i);
        }
        return new int[2];

    }
}