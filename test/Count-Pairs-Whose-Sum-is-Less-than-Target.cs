public class Solution {
    public int CountPairs(IList<int> nums, int target) {
        int n=nums.Count;
        int pairs=0;
        int[]nums1=nums.ToArray();
        Array.Sort(nums1);
        int l=0,r=n-1;
        while(l<r){
            if(nums1[l]+nums1[r]<target){
                pairs+=r-l;
                l++;
            }else r--;
        }
        return pairs;
    }
}