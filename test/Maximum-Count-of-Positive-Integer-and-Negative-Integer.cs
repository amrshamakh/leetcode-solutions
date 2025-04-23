public class Solution {
    public int MaximumCount(int[] nums) {
        /*
        idea:count the number of the positive and the number of negative integers 
        approach two pointers => while(l<r) calc the min

        1.if the mid is negative and mid+1 pos r break;
        2.if the mid negative , mid+1 negative l=mid+1 
        3.else if mid is pos and the mid-1 is pos r=mid-1 
        4.if mid is pos and mid-1 is negative
        if the mid is zero find the first pos on the right of mid and assign it to the posStart 
        and find the first neg on the left of the mid and assign it to the negEnd 

        and return the 
        max(negEnd+1,n-posStart) 
        */
        // int n=nums.Length;
        // int l=0,r=nums.Length-1;
        // int negEnd=0,posStart=0;
        // if(nums[0]>0)return n;
        // while(l<r){
        //     int mid=(l+r)/2;
        //     if(nums[mid]<0&&nums[mid+1]<0)
        //     l=mid+2;
        //     else if(nums[mid]>0&&nums[mid-1]>0)
        //     r=mid-2;
        //     else if(nums[mid]<0&&nums[mid+1]>0){negEnd=mid;posStart=mid+1;}
        //     else if(nums[mid]>0&&nums[mid-1]>0){posStart=mid;negEnd=mid-1;}
        //     else if(nums[mid]==0||(nums[mid]<0&&nums[mid+1]==0)||(nums[mid]>0&&nums[mid-1]==0)){
        //         negEnd=mid;
        //         posStart=mid;
        //         while(nums[posStart]==0&&posStart<n)posStart++;
        //         while(nums[negEnd]==0&&negEnd>=0)negEnd--;
        //     }
        //     return Math.Max(negEnd+1,n-posStart);
        // }
        // return 0;
 
    
        int n = nums.Length;
        int l = 0, r = n - 1;
        int negEnd = -1, posStart = n;

        // If all elements are positive
        if (nums[0] > 0) return n;

        // Binary search for the first positive and last negative
        while (l <= r) {
            int mid = (l + r) / 2;

            if (nums[mid] < 0) {
                negEnd = mid;
                l = mid + 1;
            } else if (nums[mid] > 0) {
                posStart = mid;
                r = mid - 1;
            } else { // nums[mid] == 0
                int i = mid, j = mid;

                // Find first positive index after mid
                while (i < n && nums[i] == 0) i++;
                posStart = i;

                // Find last negative index before mid
                while (j >= 0 && nums[j] == 0) j--;
                negEnd = j;

                break;
            }
        }

        int negCount = negEnd + 1;
        int posCount = n - posStart;

        return Math.Max(negCount, posCount);
    


    }
}