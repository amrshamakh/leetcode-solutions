public class Solution {
    public string LargestGoodInteger(string num) {
      char max='/';
      for(int i=0;i<num.Length-2;i++){
        if(num[i]==num[i+1]&&num[i]==num[i+2]){
             max = (char)Math.Max((int)max, (int)num[i]);
        }
      }
      if(max=='/')return "";
      return max.ToString() + max.ToString() + max.ToString();;
    }
}