public class Solution {
    public long CountFairPairs(int[] nums, int lower, int upper) {
        //brute force solution will get TLE 
        // int count=0;
        // for(int i=0;i<nums.Length-1;i++){
        //     for(int j=i+1;j<nums.Length;j++){
        //         int sum=nums[i]+nums[j];
        //         if(sum>=lower&&sum<=upper)count++;
        //     }
        // }
        // return count; 
        //optimized solution 
/*
[0,1,7,4,4,5] lower =3 , upper =6
[0,1,4,4,5,7] 
 
if i get the number of the pairs is greater than or equal lower and the number of that the greater than the upper 
i can create a function to calc the number of pairs than greate than n and give it lower 
and call it again with upper+1 
*/
        Array.Sort(nums);
        return (pairsGreaterThanTarget(nums,lower)-pairsGreaterThanTarget(nums,upper+1));
    }
    public long pairsGreaterThanTarget(int[]arr,int target){
        int l=0,r=arr.Length-1;
        long count=0;
        while(l<r){
            if(arr[l]+arr[r]<target){
                l++;
            }else {
                count+=r-l;
                r--;
            }
        }
        return count;
    }
}