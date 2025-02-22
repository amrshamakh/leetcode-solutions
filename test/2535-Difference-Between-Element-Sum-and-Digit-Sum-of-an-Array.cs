public class Solution {
    public int DifferenceOfSum(int[] nums) {
        int digitSum=0;
        int eSum=0;
        for(int i=0;i<nums.Length;i++){
            eSum+=nums[i];
            int temp=nums[i];
            while(temp>0){
            digitSum+=temp%10;
            temp/=10;
            }
        }
        return Math.Abs(eSum-digitSum);
    }
}