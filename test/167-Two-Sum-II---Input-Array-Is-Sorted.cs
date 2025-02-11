public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
            int[] arr = new int[2];
            Hashtable myHash = new Hashtable();
            for (int i = 0; i < numbers.Length; i++)
            {
                int complement=target-numbers[i];
                if (myHash.ContainsKey(complement))
                {
                    
                    return new int[] { (int)myHash[complement]+1,i+1 };
                }
                if (!myHash.Contains(numbers[i])) myHash.Add(numbers[i], i);
        }
            return arr;
    }
}