public class MinStack {

    Stack<int> stack = new Stack<int>();
    Stack<int> minStack = new Stack<int>();
    public MinStack() {
        
    }
    
    public void Push(int val) {
        stack.Push(val);
        if(minStack.Count == 0)
            minStack.Push(val);
        else if(val <= minStack.Peek())
            minStack.Push(val);
    }
    
    public void Pop() {
        int top = stack.Pop();
        if(minStack.Count > 0 && minStack.Peek() == top)
            minStack.Pop();
    }
    
    public int Top() {
        if(stack.Count == 0)
            return 0;
        return stack.Peek();
    }
    
    public int GetMin() {
        if(minStack.Count == 0)
            return 0;
        return minStack.Peek();
    }
}
