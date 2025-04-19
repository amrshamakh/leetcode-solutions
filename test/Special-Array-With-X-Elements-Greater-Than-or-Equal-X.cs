public class Solution {
    public int SpecialArray(int[] nums) {
        int n=nums.Length;
        Array.Sort(nums);
        for(int i=1;i<=nums.Length;i++){
            if(i==fintCandidate(nums,i))return i;
        }
        return -1;
    }
    int fintCandidate(int[]nums,int curNum){
        int l=0,r=nums.Length-1,n=nums.Length;
        int index=n;
        while(l<=r){
            int mid=(l+r)/2;
            if(nums[mid]>=curNum){
                index=mid;
                r=mid-1;
            }else l=mid+1;
        }
        return n-index;
    }
}