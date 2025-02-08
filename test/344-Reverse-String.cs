public class Solution {
    public void ReverseString(char[] s) {
    int i=0,j=s.Length-1;
    while(i<j){
       char Temp=s[i];
       s[i]=s[j];
       s[j]=Temp;
       j--;
       i++;
    }    
    }
}