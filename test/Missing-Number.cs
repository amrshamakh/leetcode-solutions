public class Solution {
    public int MissingNumber(int[] nums) {
        int n=nums.Length;
        int NumsSum=n*(n+1)/2;
        int sum=0;
        for(int i=0;i<nums.Length;i++){
            sum+=nums[i];
        }
        return NumsSum-sum;
    }
}