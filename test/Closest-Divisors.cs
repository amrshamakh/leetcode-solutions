public class Solution {
public int[] ClosestDivisors(int num) {
    int num1=num+1,  num2=num+2;
    int min = int.MaxValue;
    int[] result = new int[2];

    for (int i = (int)Math.Sqrt(num2); i >= 1; i--) {
        if (num1 % i == 0) {
            int other = num1 / i;
            if (Math.Abs(other - i) < min) {
                min = Math.Abs(other - i);
                result[0] = i;
                result[1] = other;
            }
        }
        if (num2 % i == 0) {
            int other = num2 / i;
            if (Math.Abs(other - i) < min) {
                min = Math.Abs(other - i);
                result[0] = i;
                result[1] = other;
            }
        }
    }
    return result;

    }
}