public class Solution {
    public int RomanToInt(string s) {
       
        Dictionary<char, int> Romans = new Dictionary<char, int>();
        Romans.Add('I', 1);
        Romans.Add('V', 5);
        Romans.Add('X', 10);
        Romans.Add('L', 50);
        Romans.Add('C', 100);
        Romans.Add('D', 500);
        Romans.Add('M', 1000);
         int res = Romans[s[s.Length-1]];
        for(int i = s.Length-2; i >= 0; i--)
        {
            if(Romans[s[i]]<Romans[s[i+1]])
            res -= Romans[s[i]];
            else res+=Romans[s[i]];
        }
        return res;
    }
}