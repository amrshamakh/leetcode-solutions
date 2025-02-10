public class Solution {
    public int MaxArea(int[] height) {
        int max=int.MinValue,n=height.Length;

        int l =0,r=n-1;
        while(l<r){
            //max=int.Max(height[l],height[r])
            int result=int.Min(height[l],height[r])*(r-l);
            max=int.Max(result,max);
            if(height[l]<height[r]) l++;
            else r--;
        }
        return max;
    }
}