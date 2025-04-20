public class Solution {
    public int FindNonMinOrMax(int[] nums) {
      /*
      var min = maxint
      var max = intmin
      loop over nums and get the min and max 
      loop over nums and get the num is not equal them
      */ 
      
    //   if(nums.Length<3)return -1; 
    //   int max=int.MinValue,min=int.MaxValue;
    //   for(int i=0;i<nums.Length;i++){
    //     if(nums[i]>max)max=nums[i];
    //     if(nums[i]<min)min=nums[i];
    //   }
    //   for(int i=0;i<nums.Length;i++){
    //     if(nums[i]!=min&&nums[i]!=max)return nums[i];
    //   }
    //   return -1;
    //what if we take 3 elements and return the number is valid of them 
    if(nums.Length<3)return -1; 
    int min=Math.Min(nums[0],nums[2]);
    int max=Math.Max(nums[0],nums[2]);
    if(nums[1]<max&&nums[1]>min)return nums[1];
    else if(nums[1]<min)return min;
    else return max;
    }
}