public class Solution {
    public int CountSubarrays(int[] nums) {
        /*
        get the number of the subarray of length 3 that sub[0]+sub[2]=sub[1]/2
        return 0 if not exists
        brute force 
        

        */
        int count=0;
        for(int i=0;i<nums.Length-2;i++){
            int j=i+1,k=i+2;
            if(nums[i]+nums[k]==(float)nums[j]/2)count++;
        }
        return count;
    }
}