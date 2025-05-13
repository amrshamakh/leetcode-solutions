public class Solution {
    public bool WordPattern(string pattern, string s) {
        string[] words = s.Split(' ');
        if(pattern.Length!=words.Length)return false;

        HashSet<string> set=new HashSet<string>();
        Dictionary<char,string> map = new Dictionary<char,string>();
        for(int i=0;i<words.Length;i++){
            if(map.ContainsKey(pattern[i])){
                if(map[pattern[i]]!=words[i])return false;
            }else{
                if(set.Contains(words[i]))return false;
                map.Add(pattern[i],words[i]);
                set.Add(words[i]);
            }
        }
        return true;
    }
}