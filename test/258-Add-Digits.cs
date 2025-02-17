public class Solution {
    public int AddDigits(int num) {
        if(num==0)return 0;
        int sum=0;
        //38
        //sum=8+3=11
        while(true){
            sum+=num%10;
            num/=10;
            if(num/10==0){
                sum+=num%10;
                num=sum;
                if(sum<=9)return sum;
                sum=0;
            }
        }
        return 0;
        
    }
}