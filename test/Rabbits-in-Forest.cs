public class Solution {
    public int NumRabbits(int[] answers) {
 /*
            Get the distinct elements in the answers array
            loop over the resulting array and add each element + 1 to the
            rabbits count.
            ===
            if the answer[i] is 0 then we add its frequency
            to the rabbitsCount

            if thr frequency is greater than the asnwer[i] + 1
            then we add ceil(freq/(answer[i] + 1)) * (answer[i] + 1)
            to the rabbitsCount
            
        */
         var rabbitsCount =0;
        var rabbitsFreq = new Dictionary<int,int>();
        for(int i = 0; i < answers.Length; i++){
            if(rabbitsFreq.ContainsKey(answers[i]))
                rabbitsFreq[answers[i]]++;
            else 
                rabbitsFreq[answers[i]] = 1;
        }

        foreach(var r in rabbitsFreq)
           {
            var freq = r.Value;
            var ansCount = r.Key;
             if (freq > (ansCount + 1)){
                var c = ansCount + 1;
                int groupsCount = (int)Math.Ceiling((double)freq / c);
                rabbitsCount += groupsCount * c;
             }
             else 
                rabbitsCount += ansCount + 1;
           }
        return rabbitsCount;
    }
}