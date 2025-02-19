public class Solution {
    public bool IsPerfectSquare(int num) {
        double d=Math.Sqrt(num);
        int i=(int)Math.Sqrt(num);
        return i==d;
    }
}