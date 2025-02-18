public class Solution {
   static bool IsPair(char c1,char c2){
    if(c1=='('&&c2==')')return true;
    if(c1=='{'&&c2=='}')return true;
    if(c1=='['&&c2==']')return true;
return false;
    }
    public bool IsValid(string s) {
        Stack<char> stk=new Stack<char>();
        for(int i=0;i<s.Length;i++){
            if(s[i]=='('||s[i]=='{'||s[i]=='['){
                stk.Push(s[i]);
            }else if(s[i]==')'||s[i]=='}'||s[i]==']'){
                if(stk.Count==0)return false;
                if(IsPair(stk.Peek(),s[i]))stk.Pop();
                else return false;
            }
        }
        return stk.Count==0;
    }
}