public class Solution {
    public string TriangleType(int[] nums) {
        int a=nums[0],b=nums[1],c=nums[2];
        if(nums[0]+nums[1]<=nums[2]||nums[1]+nums[2]<=nums[0]||nums[0]+nums[2]<=nums[1]){
            return "none";}
        if(nums[0]!=nums[1]&&nums[0]!=nums[2]&&nums[1]!=nums[2])return "scalene";
        if(nums[0]==nums[1]&&nums[0]==nums[2])return "equilateral";
        if((nums[0]==nums[1]&&nums[0]!=nums[2])||
        (nums[1]==nums[2]&&nums[1]!=nums[0])||nums[2]==nums[0]&&nums[2]!=nums[1])return "isosceles";
        
        return "none";
    }
}