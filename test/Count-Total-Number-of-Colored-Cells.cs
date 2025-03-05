public class Solution {
    public long ColoredCells(int n) {
        long x=--n;
        return 1+2*(x*(x+1));
    }
}