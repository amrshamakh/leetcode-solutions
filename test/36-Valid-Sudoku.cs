public class Solution {
    public bool IsValidSudoku(char[][] board) {
        // Each row must contain the digits 1-9 without repetition
        for(int i=0;i<board.Length;i++){
        HashSet<char> set=new HashSet<char>();
            for(int j=0;j<9;j++){
                if(board[i][j]=='.')continue;
                if(set.Contains(board[i][j]))return false;
                else set.Add(board[i][j]);           
            }
            }
            // Each column must contain the digits 1-9 without repetition
     for(int j=0;j<9;j++){
        HashSet<char> set=new HashSet<char>();
            for(int i=0;i<9;i++){
                if(board[i][j]=='.')continue;
                if(set.Contains(board[i][j]))return false;
                else set.Add(board[i][j]);
            }
        }
        // Each of the nine 3 x 3 sub-boxes of the grid must contain the digits 1-9 without repetition.
        for(int row=0;row<9;row+=3){
            for(int col=0;col<9;col+=3){
        HashSet<char> set=new HashSet<char>();
                for(int i=0;i<3;i++ ){
                    for(int j=0;j<3;j++){
                        char value=board[row+i][col+j];
                        if(value=='.')continue;
                        if(set.Contains(value))return false;
                        else set.Add(value);
                    }
                }
            }
        }
        return true;
    }//method
}