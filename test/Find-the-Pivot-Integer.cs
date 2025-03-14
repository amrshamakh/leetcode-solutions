public class Solution {
    public int PivotInteger(int n) {
        int total = n * (n + 1) / 2;
        int x = (int)Math.Sqrt(total); // Calculate the potential pivot

        // Check if x is a valid pivot
        if (x * x == total) return x;
        return -1;
    }
}