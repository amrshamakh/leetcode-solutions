public class Solution {
    public int SumCounts(IList<int> nums) {
        int res=0;
        for(int i=0;i<nums.Count;i++){
            HashSet<int>set=new HashSet<int>();
            for(int j=i;j<nums.Count;j++){
                set.Add(nums[j]);
                res+=set.Count*set.Count;
            }
        }return res;
    }
}