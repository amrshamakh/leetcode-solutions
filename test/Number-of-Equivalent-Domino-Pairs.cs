public class Solution {
    public int NumEquivDominoPairs(int[][] dominoes) {
        /*
        the brute force that we will use nasted loop to check for every pair what the pairs is equivelent 
        the optimized is to use the dictionary of freq and the key is the sum and the value is the freq 
        if the sum of a+b not exsists i will add it with freq 1 and if exsists increase the counter with freq and freq++
        return the count
        */
        Dictionary<int,int>sumFreq=new Dictionary<int,int>();
        int count=0;
        for(int i=0;i<dominoes.Length;i++){
            int currentSum=10*Math.Min(dominoes[i][0],dominoes[i][1])+Math.Max(dominoes[i][0],dominoes[i][1]);
            if(sumFreq.ContainsKey(currentSum)){
                count+=sumFreq[currentSum];
                sumFreq[currentSum]++;
            }else sumFreq.Add(currentSum,1);
        }
        return count;
    }
}