public class Solution {
    public int MinimumRecolors(string blocks, int k) {
        int w = 0;
        
        int start = 0, end = 0;
        for ( end = 0; end < k; end++) {
            if (blocks[end] == 'W') w++;
        }
        int min = w;
        for (; end < blocks.Length; end++, start++)
        {
            if (blocks[end] == 'W') w++;
            if (blocks[start] == 'W') w--;
            min=Math.Min(min, w);
        }

        return min;

    }
}