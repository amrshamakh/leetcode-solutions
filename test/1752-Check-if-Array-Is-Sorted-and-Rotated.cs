public class Solution {
    public bool Check(int[] nums) {
       int count=1;
       for(int i=1;i<2*nums.Length;i++){
        if(nums[i%nums.Length]>=nums[(i-1)%nums.Length])count++;
        else count=1;
        if(count==nums.Length)return true;
       } 
       return nums.Length==1;
    }
}