public class Solution {
    public string DestCity(IList<IList<string>> paths) {
        HashSet<string>set=new HashSet<string>();
        foreach(var path in paths){
            set.Add(path[0]);
        }
        foreach(var path in paths){
            if(!set.Contains(path[1]))return path[1];
        }
        return string.Empty;
    }
}