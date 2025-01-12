public class Solution {
    public bool CanBeValid(string s, string locked) {
        if(s.Length%2==1)return false;
      int opening =0,closing=0,wildCard=0;
      for(int i=0;i<s.Length;i++){ 
          if(locked[i]=='0') wildCard++;
          else if(s[i]=='(') opening++;
          else closing++;
          if(opening+wildCard<closing)return false;
      }
      opening =closing=wildCard=0;
      for(int i=s.Length-1;i>=0;i--){
         if(locked[i]=='0') wildCard++;
          else if(s[i]=='(') opening++;
          else closing++;
          if(closing+wildCard<opening)return false;
      }
      return true;
    }
}