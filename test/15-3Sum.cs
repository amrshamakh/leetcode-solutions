public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
Array.Sort(nums);
IList<IList<int>> list = new List<IList<int>>();
for (int i = 0; i < nums.Length-2; i++)
{
if (i > 0 && nums[i] == nums[i - 1]) continue; // Skip duplicate elements
int left = i + 1, right = nums.Length - 1;
while (left<right)
{
int sum = nums[i] + nums[left] + nums[right];

if (sum == 0)
{
    //IList<int>=new IList<int>();
    list.Add((new List<int> { nums[i], nums[left], nums[right] }));
    while (left < right && nums[left] == nums[left + 1]) left++;
    while (left < right && nums[right] == nums[right - 1]) right--;
    left++;
    right--;
}
else if (sum < 0) left++;
else if (sum > 0) right--;
                    
}
}
return list;

    }
}