public class Solution {
        public  string MakeFancyString(string s)
        {
            if(s.Length<3)return s;
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < s.Length - 2; i++) {
                if (s[i] == s[i + 1] && s[i] == s[i + 2]) continue;
                stringBuilder.Append(s[i]);
            }

            stringBuilder.Append(s[s.Length - 2]);
            stringBuilder.Append(s[s.Length - 1]);
            return stringBuilder.ToString();
        }
}