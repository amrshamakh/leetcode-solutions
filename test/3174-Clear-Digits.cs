public class Solution {
    public string ClearDigits(string s) {
        /*
        stack
        if it's letter push  
        if it's digit see the top of stack if it's empty push if it's letter pop 
        
        */
        StringBuilder S=new StringBuilder();
        Stack<char> stk = new Stack<char>();
        for(int i=0;i<s.Length;i++){
            if(char.IsLetter(s[i]))stk.Push(s[i]);
            else if(char.IsDigit(s[i])){
                if(stk.Count==0)stk.Push(s[i]);
                if(char.IsLetter(stk.Peek()))stk.Pop();
            }
        }
        while(stk.Count>0)
        S.Insert(0, stk.Pop());
        return S.ToString();
    }
}

