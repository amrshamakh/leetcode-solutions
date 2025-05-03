public class Solution {
    public int MinDominoRotations(int[] tops, int[] bottoms) {
       /*
       approach :
       i will iterate from 1->6 
       for each number i will check if its valid for the top if it valid i will check it for the bottom 
       and get the minimum between them 
       */ 
       for(int i=1;i<=6;i++){
        int validTopRotations=0;
        bool valid=true;
        for(int j=0;j<tops.Length;j++){
            if(tops[j]==i)continue;
            else if(bottoms[j]==i)validTopRotations++;
            else {
                valid=false;
                break;
            }
        }
        if(valid){
            int validBottomRotations=0;
            for(int k=0;k<bottoms.Length;k++){
                if(bottoms[k]==i)continue;
                else validBottomRotations++;
                
            }
            return Math.Min(validBottomRotations,validTopRotations);
        }
       }
       return -1;
    }
}