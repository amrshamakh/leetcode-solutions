public class MinStack {
    Stack<int> stkMin=new Stack<int>();
    Stack<int> stk=new Stack<int>();
    public MinStack() {
        
    }
    
    public void Push(int val) {
        stk.Push(val);
        if(stkMin.Count == 0 ||val<=stkMin.Peek()){
            stkMin.Push(val);
            }
    }
    
    public void Pop() {
        if(stk.Count==0)throw new InvalidOperationException(\Stack is empty\);
        if(stk.Peek()==stkMin.Peek())stkMin.Pop();
        stk.Pop();
    }
    
    public int Top() {
        if(stk.Count==0)throw new InvalidOperationException(\Stack is empty\);
        return stk.Peek();
    }
    
    public int GetMin() {
        if(stkMin.Count==0)throw new InvalidOperationException(\Stack is empty\);
        return stkMin.Peek();
    }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(val);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */