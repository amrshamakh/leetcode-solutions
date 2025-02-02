public class Solution {
     public static bool IsSorted(int[] arr)
        {
            if (arr == null) return true;
            for (int i = 0; i < arr.Length-1; i++) {
                if (arr[i + 1] < arr[i]) return false;
            }
            return true;
        }
        public  bool Check(int[] nums)
        {
            int[]A=new int[nums.Length];
            int x = 0;
            while (x < nums.Length)
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    A[(i + x) % nums.Length] = nums[i];
                }

                if (IsSorted(A)){
                    Console.WriteLine(x);
                    return true; 
                }
                x++;
            }
            return false;
        }
    }

