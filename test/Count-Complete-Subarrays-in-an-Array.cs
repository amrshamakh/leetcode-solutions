public class Solution {
     // Console.WriteLine(i);
    public int CountCompleteSubarrays(int[] nums) {
        /*
        sliding window
        idea: count the number of subarrays with the number of distinct elements in the nums array
        edgecases:if there is one distinct element return the sum of elements from 1->set.Size(n*(n+1)/2)
        approach:
        1.count the unique elements in the nums 
        2.i will use a dictionary to count the number of the distinct elements in each subarray and get the freq to apply
        the sliding window 
         iterate over the array elements and while the count of the freq is equal k increase the count by nums length -i  
        
        */
        int count=0;
        int n=nums.Length;
        int l=0;
        int distinctCount = nums.Distinct().Count();
        Dictionary<int,int> uniqueElements=new Dictionary<int,int>();
        for(int i=0;i<nums.Length;i++){
            if(!uniqueElements.ContainsKey(nums[i]))uniqueElements.Add(nums[i],0);
            uniqueElements[nums[i]]++;
            while(uniqueElements.Count==distinctCount){
                count+=n-i;
                uniqueElements[nums[l]]--;
                if( uniqueElements[nums[l]]==0) uniqueElements.Remove(nums[l]);
                l++;
            }
        }
        return count;

    }
}