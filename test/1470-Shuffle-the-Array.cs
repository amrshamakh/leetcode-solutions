public class Solution {
    public int[] Shuffle(int[] nums, int n) {
        int[]result=new int[2*n];
        int i=0,j=0;
        while(j<n){
        result[i]=nums[j];
        j++;
        i+=2;
        }
        int k = 1, l = n;
        while (l < 2*n)
        {
            result[k] = nums[l];
            l++;
            k += 2;
        }
        return result;
    }
}