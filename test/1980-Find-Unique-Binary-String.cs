public class Solution {
    public string FindDifferentBinaryString(string[] nums) {
        int n=nums[0].Length;
        int maxV=(int)Math.Pow(2,n)-1;
        HashSet<int> myHash=new HashSet<int>();
        for(int i=0;i<nums.Length;i++){
            myHash.Add(Convert.ToInt32(nums[i], 2));
        }
        for(int i=0;i<=maxV;i++){
            if(!myHash.Contains(i))
             return Convert.ToString(i, 2).PadLeft(n, '0');
            
        }
        return null;
        
    }
}