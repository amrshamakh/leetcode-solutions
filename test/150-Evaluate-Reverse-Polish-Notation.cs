public class Solution {
    public static int operation(int op1,int op2,string op){
        if(op==\+\)return op1+op2;
        if(op==\-\)return op1-op2;
        if(op==\*\)return op1*op2;
        if(op==\/\)return op1/op2;
        return -1;
    }
    public int EvalRPN(string[] tokens) {
       Stack<int> stk=new Stack<int>();
       for(int i=0;i<tokens.Length;i++){
        if(int.TryParse(tokens[i],out int option))stk.Push(option);
        else {
            int op2=stk.Pop();
            int op1=stk.Pop();
            stk.Push(operation(op1,op2,tokens[i]));
        }
       }
       return stk.Pop();

    }
}