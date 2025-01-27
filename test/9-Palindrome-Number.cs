public class Solution {
    public bool IsPalindrome(int x) {
         int temp = x;
            int reversed = 0;
            if (x < 0) return false;
            while (temp > 0)
            {
                reversed = reversed * 10 + temp % 10;
                temp /= 10;
                //Console.WriteLine(reversed);
            }
            if (reversed == x) return true;
            return false;
    }
}