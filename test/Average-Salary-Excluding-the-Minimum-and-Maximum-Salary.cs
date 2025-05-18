public class Solution {
    public double Average(int[] salary) {
        double min=int.MaxValue;
        double max=int.MinValue;
        double sum=0;
        foreach(var s in salary){
            if(s>max)max=s;
            if(s<min)min=s;
            sum+=s;
        }
        return (sum-max-min)/(salary.Length-2);
    }
}