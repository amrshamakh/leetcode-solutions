public class Solution {
    public int SubarraySum(int[] nums, int k) {
     Dictionary<int, int> dic = new Dictionary<int, int>();
     dic[0]=1;
     int count=0,sum=0;
     for(int i=0;i<nums.Length;i++){
        sum+=nums[i];
        int f=sum-k;
        if(dic.ContainsKey(f)) count+=dic[f];
        if(dic.ContainsKey(sum)) dic[sum]++;
        else dic[sum]=1;
     }
     return count ;

    }
}