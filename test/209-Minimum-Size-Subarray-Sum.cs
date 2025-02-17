public class Solution {
    public int MinSubArrayLen(int target, int[] nums) {
        int l=0,r=0,sum=0,min=int.MaxValue;
        for( r=0;r<nums.Length;r++){
            sum+=nums[r];
            while(sum>=target) {
                min=Math.Min(min,r-l+1);
                sum-=nums[l];
                l++;
            }
        }
        return (min==int.MaxValue)?0:min;
    }
}