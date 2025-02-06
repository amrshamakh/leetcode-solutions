public class Solution {
    public static int C2(int n)
{
    return (n * (n - 1)) / 2;
}
    public int TupleSameProduct(int[] nums) {
                   int count = 0;
            Dictionary<int,int> myhash = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++) { 
            for(int j=i+1; j<nums.Length; j++)
                {
                    if (myhash.ContainsKey(nums[i] * nums[j]))
                        myhash[nums[i] * nums[j]]++;
                    else
                        myhash[nums[i] * nums[j]] = 1;
                }
            }
            foreach (int i in myhash.Values) {
                if (i > 1) {
                    
                    count += C2(i) * 8;
                }
            }
            return count;
      
    }
}