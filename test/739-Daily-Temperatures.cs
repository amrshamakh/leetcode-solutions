public class Solution {
    public int[] DailyTemperatures(int[] temperatures)
    {
        int[] result = new int[temperatures.Length];
        Stack<int> stk = new Stack<int>();
        for (int i = 0; i < temperatures.Length; i++)
        {
            while (stk.Count > 0 && temperatures[i] > temperatures[stk.Peek()])
            {
                int prev = stk.Pop();
                result[prev] = i - prev;
            }
            stk.Push(i);
        }
        return result;
    }
}