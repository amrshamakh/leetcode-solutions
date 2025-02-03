public class Solution {
    public int LongestMonotonicSubarray(int[] nums) {
        if(nums.Length==0||nums.Length==1)return nums.Length; 
        int count1=1,count2=1, max=int.MinValue;
       for(int i=1;i<nums.Length;i++){
        if(nums[i]>nums[i-1])count1++;
        else count1=1;
        if(nums[i]<nums[i-1])count2++;
        else count2=1;
        max=int.Max(int.Max(count1,count2),max);
       }
        return max;
        
    }
}