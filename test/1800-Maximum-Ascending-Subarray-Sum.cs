public class Solution {
    public int MaxAscendingSum(int[] nums) {
        if(nums.Length==1)return nums[0];
        int max = int.MinValue;
int current = nums[0];

for (int i = 1; i < nums.Length; i++)
{
    if (nums[i] > nums[i - 1])
        current += nums[i];
    else
    {
        max = int.Max(current, max);
        current = nums[i];
    }
        max = int.Max(current, max);
    
}
return max;
    }
}