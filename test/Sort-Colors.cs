public class Solution {
    public void SortColors(int[] nums) {
        int zero=0,one=0,two=0;
        for(int j=0;j<nums.Length;j++){
            if(nums[j]==0)zero++;
            else if(nums[j]==1)one++;
            else two++;
        }
        int i=0;
        while(zero>0){
            nums[i]=0;
            zero--;
            i++;
        }
        while(one>0){
            nums[i]=1;
            one--;
            i++;
        }
        while(two>0){
            nums[i]=2;
            two--;
            i++;
        }

    }
}