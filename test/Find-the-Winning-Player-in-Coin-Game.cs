public class Solution {
    public string WinningPlayer(int x, int y) {
        /*every time it should be x>0 and y >4*/
        // int f=1;
        // while(x>=1&&y>=4)
        // {
        //     x-=1;
        //     y-=4;
        //     f++;
        // }
        // if(f%2==1)return "Bob";
        // else return "Alice";

        int turn= Math.Min(x,y/4);
        return turn%2==1 ? "Alice":"Bob";
        
    }
}