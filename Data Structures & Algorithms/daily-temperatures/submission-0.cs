public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        int n = temperatures.Length;
        int[] ans = new int[n];
        Stack<int> stack = new Stack<int>();

        for(int i=0; i<n; i++)
        {
            while(stack.Count > 0 && temperatures[i] > temperatures[stack.Peek()])
            {
                int ind = stack.Pop();
                ans[ind] = i - ind;
            }

            stack.Push(i);
        }

        return ans;
    }
}
