public class Solution {
    public long MinSum(int[] nums1, int[] nums2) {
        /*
        what if i get the sum and the number of zeros in both arrays and 
        for the array with less zeros if i make the sum = sum+ number of zeros it should be greater than the or equal
        the sum of the another array 
        if it s equal return sum and if it gerater i will return its sum okayyyyyy thats good idea lets do it 
        */
        long sum1=0,nums1Zeros=0,sum2=0,nums2Zeros=0;
        foreach(var num in nums1){
            if(num==0) nums1Zeros++;
            else sum1+=num;
        }
        foreach(var num in nums2){
            if(num==0) nums2Zeros++;
            else sum2+=num;
        }
        Console.WriteLine($"{sum1},{nums1Zeros},{sum2},{nums2Zeros}");
        // if(nums1Zeros<nums2Zeros){
        //     if(sum1+nums1Zeros<nums2Zeros+sum2)return -1;
        //     else return sum1+nums1Zeros;
        // }else{
        //     if(sum2+nums2Zeros<nums1Zeros+sum1)return -1;
        //     else return sum2+nums2Zeros;
        // }
        
        long newSum1=sum1+nums1Zeros;
        long newSum2=sum2+nums2Zeros;
        if((nums1Zeros==0&&sum1<newSum2)||(nums2Zeros==0&&sum2<newSum1))return -1;
        return Math.Max(newSum1,newSum2);
       // return -1;
    }
}