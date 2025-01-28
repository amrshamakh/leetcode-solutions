public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        Hashtable myHash=new Hashtable();
        for (int i = 0; i < nums.Length; i++) {
            if (myHash.ContainsKey(nums[i]))  return true; 
            else{
                    myHash.Add(nums[i], i);
             }
                
            }
            return false;
    }
}