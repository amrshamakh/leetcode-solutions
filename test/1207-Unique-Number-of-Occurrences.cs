public class Solution {
    public bool UniqueOccurrences(int[] arr) {
        Dictionary<int ,int> dic=new Dictionary<int ,int>();
        foreach(int num in arr){
            if(dic.ContainsKey(num))dic[num]++;
            else dic.Add(num,1);
        }
        HashSet<int> set = new HashSet<int>();
        foreach(int value in dic.Values)
        {
            if (!set.Contains(value)) { 
                set.Add(value);
            }
            else
            {
                return false;
            }
            
        }
        return true;
        
    }
}