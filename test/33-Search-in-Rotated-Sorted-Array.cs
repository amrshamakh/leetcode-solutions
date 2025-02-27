public class Solution {
    public int Search(int[] nums, int target) {
        int L=0,R=nums.Length-1;
        while(L<=R){
            int mid=((L+R)/2);
            if(nums[mid]==target)return mid;
            //check if we are in the left sorted arr
            if(nums[mid]>=nums[L]){
                if(nums[mid]<target||target<nums[L])
                L=mid+1;
                else R=mid-1;
            }
            //check if we are in the right sorted arr
            else{
                if(target<nums[mid]||target>nums[R])R=mid-1;
                else L=mid+1;
            }
        }
        return -1;
    }
}