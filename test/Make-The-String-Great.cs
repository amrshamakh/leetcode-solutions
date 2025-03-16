public class Solution {
    public string MakeGood(string s) {
        Stack<char>stk=new Stack<char>();
        for(int i=0;i<s.Length;i++){
            if(stk.Count>0&&(stk.Peek()==(char)(s[i]+32)||stk.Peek()==(char)(s[i]-32)))stk.Pop();
            else stk.Push(s[i]);
        }
        if (stk.Count==0 )return "";
        return new string(stk.Reverse().ToArray());
    }
}