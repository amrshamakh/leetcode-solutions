public class Solution {
    public bool IsPowerOfThree(int n) {
        int num=1;
        while(num<=n/3){
            num*=3;
        }
        return num==n;
    }
}