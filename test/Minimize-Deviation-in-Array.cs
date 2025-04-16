public class Solution {
public int MinimumDeviation(int[] nums) {
    // Use SortedSet to keep values sorted
    SortedSet<int> set = new SortedSet<int>();
    
    // First, make all odd numbers even by multiplying by 2
    // This ensures we only need to perform division operations later
    foreach (int num in nums) {
        set.Add(num % 2 == 0 ? num : num * 2);
    }
    
    int minDeviation = set.Max - set.Min;
    
    // Continue until the maximum element is odd (can't be reduced further)
    while (set.Max % 2 == 0) {
        int max = set.Max;
        set.Remove(max);
        set.Add(max / 2);
        minDeviation = Math.Min(minDeviation, set.Max - set.Min);
    }
    
    return minDeviation;
}
}