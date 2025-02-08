public class Solution {
    public bool IsPalindrome(string s) {
        StringBuilder result=new StringBuilder();
        foreach(char c in s){
            if(char.IsLetterOrDigit(c))result.Append(char.ToLower(c));
        }
        int l=0,r=result.Length-1;
        while(l<r){
            if(result[l]!=result[r])return false;
            l++;
            r--;
        }
        return true;
    }
}