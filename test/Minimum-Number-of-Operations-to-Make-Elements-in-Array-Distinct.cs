public class Solution {
    public int MinimumOperations(int[] nums) {
        int n=nums.Length;
        HashSet<int> distinct = new HashSet<int>();
        for(int i = nums.Length - 1; i >= 0; i--){
            if (distinct.Contains(nums[i]))
            {
                int remaining =n-distinct.Count;
                if (remaining % 3 == 0) return remaining / 3;
                else return (remaining / 3)+1;
            }else distinct.Add(nums[i]);
            
        }
        return 0;
      /*
Idea: 
    we need to have an array that has all unique values by repeating an operation that delete the first 3 items.

Steps:
    1- make sure the list doesn't contain unique elements
    2- 
     brute force approach 
    1 - iterate over array every 3 steps till reaching for unique elements by iterating over the remaining part

    *** another sol
    iterate backward over array and check if the element we are over is distinct then if we found the element is not unique then will use its index to get the needed steps to do the operation
No file chosen

*/  
 


        }
    }
