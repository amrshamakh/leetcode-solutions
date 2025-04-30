public class Solution {
    public int FindNumbers(int[] nums) {
        string s="";
        int count=0;
     for(int i=0;i<nums.Length;i++){
        s=nums[i].ToString();
        if(s.Length%2==0)count++;
     } 
     return count;  
    }

}