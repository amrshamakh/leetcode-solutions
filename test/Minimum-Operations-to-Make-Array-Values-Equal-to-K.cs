public class Solution {
    public int MinOperations(int[] nums, int k) {
        HashSet<int>set=new HashSet<int>();
        int min=int.MaxValue;
        for(int i=0;i<nums.Length;i++){
            min=Math.Min(nums[i],min);
            set.Add(nums[i]);
        }
        if(min<k)return -1;
        else if(min==k)return set.Count-1;
        else return set.Count;

    }
}