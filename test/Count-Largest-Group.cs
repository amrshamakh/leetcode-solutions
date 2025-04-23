public class Solution {
    public int CountLargestGroup(int n) {
        /*
        idea: given n get the sum of each digit and calc the sum of it and group it with the int with the same digits sum
        edgecases:if the n<=9 return 1;
        approach: i will calc the sum of digit for each num and put it in hashtable and the sum of it as a value and return 
        the max value in it
        */
        int max=0;
        Dictionary<int,int> freq=new Dictionary<int,int>();
        for(int i=1;i<=n;i++){
            int DSum=DigitsSum(i);
            if(!freq.ContainsKey(DSum))freq.Add(DSum,0);
            freq[DSum]++;
            max=Math.Max(max,freq[DSum]);
        }
        int count=0;
        foreach(int val in freq.Values) if(val==max)count++;
        return count;
        
    }
    public int DigitsSum(int n){
        int s=0;
        while(n>0){
            s+=n%10;
            n/=10;
        }
        return s;
    }
}