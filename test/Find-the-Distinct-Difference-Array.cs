public class Solution {
    public int[] DistinctDifferenceArray(int[] nums) {

         int[]diff=new int[nums.Length];
        for(int i=0;i<nums.Length;i++){
         
            HashSet<int>Leftset=new HashSet<int>();
            HashSet<int>RightSet=new HashSet<int>();
            for(int j=i;j>=0;j--){
                Leftset.Add(nums[j]);
            }
            for(int k=i+1;k<nums.Length;k++){
                RightSet.Add(nums[k]);
            }
            diff[i]=Leftset.Count-RightSet.Count;
        }
        return diff;
    }
}