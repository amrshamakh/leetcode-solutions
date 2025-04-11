public class Solution {
    public int CountSymmetricIntegers(int low, int high) {
    /*
    idea: return the number of int with 2n length and the first n= the the second n
    edge cases :the number of digits is odd 
    approach: iterate over integers from low to high and for each digit if it's even calculate the first part sum and 
    the second if they are equals increase the counter 
    (int)Math.Floor(Math.Log10(Math.(number))) + 1 to get the length of the integer 
    */    
    int num=low ;
    int count=0;
    while(num<=high){
        int n2=num;
        
        int Nlen=(int)Math.Log10(num) + 1;
        if(Nlen%2==1)
        {
            num++;
            continue;
            }
        int sum1=0,sum2=0;
        for(int i=0;i<Nlen/2;i++){
            sum1+=num%10;
            num/=10;
        }
               
        for(int i=0;i<Nlen/2;i++){
           sum2+=num%10;
            num/=10;
        }
        if(sum1==sum2)count++;
        num=n2+1;
    }
    return count;

    }
}