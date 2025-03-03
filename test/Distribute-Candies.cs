public class Solution {
    public int DistributeCandies(int[] candyType) {
return Math.Min(candyType.Length/2,new HashSet<int>(candyType).Count);
}}