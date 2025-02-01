public class Solution {
     public static bool IsAnagram(string s, string t) {
        if(s.Length!=t.Length)return false;
        int[]arr=new int[26];
        for(int i=0;i<s.Length;i++){
            arr[s[i]-'a']++;
        }
    for(int i=0;i<t.Length;i++){
            arr[t[i]-'a']--;
        }
        for(int i=0;i<arr.Length;i++){
            if(arr[i]>0)return false;
        }
        return true;
    }
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        bool[] arr=new bool[10000];
        IList<IList<string>> result=new   List<IList<string>>();
        for(int i=0;i<strs.Length;i++){
            if(arr[i])continue;
        IList<string> current=new List<string>();
        current.Add(strs[i]); 
            for(int j=i+1;j<strs.Length;j++){
                if(IsAnagram(strs[i],strs[j])){
                    current.Add(strs[j]);
                    arr[j]=true;
                }
            }
            result.Add(current);
        }
        return result;
    }
}