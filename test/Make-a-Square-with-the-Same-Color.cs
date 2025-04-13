public class Solution {
    public bool CanMakeSquare(char[][] grid) {
        /*approach: check on every two columns on two adj rows 
        there must be one of the characters is diffrent otherwise continue to the next
        two adj rows 
        */
        int B='B'+'B'+'B'+'W';
        int W='B'+'W'+'W'+'W';
        int b1='B'+'B'+'B'+'B';
        int w1='W'+'W'+'W'+'W';
        
       
            int res1=grid[0][0]+grid[0][1]+grid[1][0]+grid[1][1];
            if(res1==B||res1==W||res1==b1||res1==w1)return true;

            int res2=grid[1][0]+grid[1][1]+grid[2][0]+grid[2][1];
            if(res2==B||res2==W||res2==b1||res2==w1)return true;

            int res3=grid[0][1]+grid[0][2]+grid[1][1]+grid[1][2];
            if(res3==B||res3==W||res3==b1||res3==w1)return true;

            int res4=grid[1][1]+grid[1][2]+grid[2][1]+grid[2][2];
            if(res4==B||res4==W||res4==b1||res4==w1)return true;
        
        return false;
    }
}