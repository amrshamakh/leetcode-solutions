public class Solution {
    public static int Digitsum(int i){
        int result=0;
        while(i>0){
            result+=i%10;
            i/=10;
        }
        return result;
    }
    public int MaximumSum(int[] nums) {
       Dictionary<int,int> myhash=new Dictionary<int,int>();
       int max=-1;
       for(int i=0;i<nums.Length;i++){
        int sum=Digitsum(nums[i]);
        if(myhash.ContainsKey(sum)) {
            max=Math.Max(myhash[sum]+nums[i],max);
            myhash[sum]=Math.Max(myhash[sum],nums[i]);
        }
        else myhash[sum]=nums[i];
       }
       return max;
    }
}