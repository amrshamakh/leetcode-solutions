public class Solution {
    public bool ContainsDuplicate(int[] nums) {
          HashSet<int> result = new HashSet<int>();
            for (int i = 0; i < nums.Length; i++) { 
            result.Add(nums[i]);
            }
            if (result.Count < nums.Length) return true;

            return false;
    }
}