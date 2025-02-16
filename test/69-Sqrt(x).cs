public class Solution {
    public int MySqrt(int x) {
        if(x<=1)return x;
        int l=0,r=x;
        while(l<=r){
            int mid=(l+r)/2;
            if(mid==x/mid)return mid;
            else if(mid>x/mid)r=mid-1;
            else if(mid<x/mid)l=mid+1;
        }
        return r;
    }
}// l
//l r  
//01234567