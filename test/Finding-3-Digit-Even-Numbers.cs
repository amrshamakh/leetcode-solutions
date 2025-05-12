public class Solution {
    public int MinStoneSum(int[] piles, int k) {
        PriorityQueue<int, int> pq = new PriorityQueue<int, int>();
        foreach (int num in piles)
        {
            pq.Enqueue(num, -num);
        }
        for(int i=0;i<k;i++){
            int Num = pq.Dequeue();
            int Removed=Num/2;
            Num-=Removed;
            pq.Enqueue(Num,-Num);
        }
        //get the sum
        int sum=0;
        while(pq.Count>0){
            sum+=pq.Dequeue();
        }
        return sum;
    }
}