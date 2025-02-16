public class Solution {
    public bool IsPowerOfTwo(int n) {
        double b=Math.Log2(n);
        int c=(int)Math.Log2(n);
        return b==c;
    }
}