public class Solution {
    public int MaximumProduct(int[] nums) {   
       if (nums.Length == 3)
        {
            return nums[0] * nums[1] * nums[2];
        }
        int n1=-1001,n2=-1001,n3=-1001,Nega1=int.MaxValue,Nega2=int.MaxValue;
        for(int i=0;i<nums.Length;i++){
            if(nums[i]>n1){
                n3=n2;
                n2=n1;
                n1=nums[i];
                }
            else if(nums[i]>n2){
                n3=n2;
                n2=nums[i];
            }else if(nums[i]>n3){
                n3=nums[i];
            }
            if(nums[i]<Nega1){
                Nega2=Nega1;
                Nega1=nums[i];
            }
            else if(nums[i]<Nega2){
            Nega2=nums[i];
            }
        }
        return Math.Max(n1*n2*n3,n1*Nega1*Nega2);

    }
}