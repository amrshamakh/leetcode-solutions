public class Solution {
    public int FindNonMinOrMax(int[] nums) {
      /*
      var min = maxint
      var max = intmin
      loop over nums and get the min and max 
      loop over nums and get the num is not equal them
      */ 
      
      if(nums.Length<3)return -1; 
      int max=int.MinValue,min=int.MaxValue;
      for(int i=0;i<nums.Length;i++){
        if(nums[i]>max)max=nums[i];
        if(nums[i]<min)min=nums[i];
      }
      for(int i=0;i<nums.Length;i++){
        if(nums[i]!=min&&nums[i]!=max)return nums[i];
      }
      return -1;

    }
}