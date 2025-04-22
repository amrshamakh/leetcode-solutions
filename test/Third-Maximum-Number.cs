public class Solution {
    public int ThirdMax(int[] nums) {

        // return thirdMax!=int.MinValue?thirdMax:FirstMax;
        HashSet<int>Set=new HashSet<int>();
        for(int i=0;i<nums.Length;i++){
            Set.Add(nums[i]);
        }
        int FirstMax=int.MinValue;
        int SecondMax=int.MinValue;
        int thirdMax=int.MinValue;
        int max=int.MinValue;
        if(Set.Count<3){
            foreach(int val in Set)
            max=Math.Max(val,max);
            return max;
        }
        

        foreach(int val in Set){
            if(val>FirstMax){
                thirdMax=SecondMax;
                SecondMax=FirstMax;
                FirstMax=val;
            }else if(val>SecondMax){
                thirdMax=SecondMax;
                SecondMax=val;
            }else if(val>thirdMax) thirdMax=val;
        }
         return thirdMax;
    }
}