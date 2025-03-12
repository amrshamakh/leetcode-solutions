public class Solution {

    public static bool isNotSympol(char c){
    //  return (c!=' '&&c!='!'c!='?'&&c!='\''&&c!=','&&c!=';'&&c!='.');
     return c != ' ' && c != '!' && c != '?' && c != '\'' && c != ',' && c != ';' && c != '.';
    }
    public string MostCommonWord(string paragraph, string[] banned) {
        HashSet<string>bannedS=new HashSet<string>();
        foreach(string s in banned){
            bannedS.Add(s);
        } 
        Dictionary<string,int>freq=new Dictionary<string,int>();
        int i=0;
        while(i<paragraph.Length){
            StringBuilder s=new StringBuilder();
            while(i < paragraph.Length&&isNotSympol(paragraph[i])){
                s.Append(char.ToLower(paragraph[i]));
                i++;
            }
            string ss=s.ToString();
        if (!string.IsNullOrEmpty(ss) && !bannedS.Contains(ss)) {
            if (freq.ContainsKey(ss))
                freq[ss]++;
            else
                freq[ss] = 1;
        }
             while (i < paragraph.Length && !isNotSympol(paragraph[i])) {
                i++;
            }
            
        }
        int max=0;
        string maxS="";
        foreach(var item in freq){
            if(item.Value>max){maxS=item.Key;
            max=item.Value;}
        }
        return maxS;
    }
}