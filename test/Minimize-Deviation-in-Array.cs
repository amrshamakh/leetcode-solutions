public class Solution {
public int MinimumDeviation(int[] nums) {
    SortedSet<int> set = new SortedSet<int>();
    foreach (int num in nums) {
        set.Add(num % 2 == 0 ? num : num * 2);
    }
    
    int minDeviation = set.Max - set.Min;
    while (set.Max % 2 == 0) {
        int max = set.Max;
        set.Remove(max);
        set.Add(max / 2);
        minDeviation = Math.Min(minDeviation, set.Max - set.Min);
    } 
    return minDeviation;
}
}