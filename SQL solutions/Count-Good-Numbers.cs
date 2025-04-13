public class Solution {
    const long MOD = 1000000007;

    public int CountGoodNumbers(long n) {
        long evenCount = (n + 1) / 2;
        long oddCount = n / 2;

        long evenWays = ModPow(5, evenCount);
        long oddWays  = ModPow(4, oddCount);

        return (int)((evenWays * oddWays) % MOD);
    }

    private long ModPow(long b, long exp) {
        long result = 1;
        b %= MOD;

        while (exp > 0) {
            if ((exp & 1) == 1)
                result = (result * b) % MOD;

            b = (b * b) % MOD;
            exp >>= 1;
        }

        return result;
    }
}
