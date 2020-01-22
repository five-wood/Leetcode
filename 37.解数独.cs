/*
 * @lc app=leetcode.cn id=37 lang=csharp
 *
 * [37] 解数独
 */

// @lc code=start
using System.Collections.Generic;
public class Solution {
    public class SpaceInfo
    {
        int x=0;
        int y=0; 
        List<int> cantFix=new List<int>();
        SpaceInfo(int x,int y)
        {
            this.x=x;
            this.y=y;
        }
    }
    public void SolveSudoku(char[][] board) {
        for(int i=0;i<board.Length;i++)
        {
            char[] row=board[i];
            for(int j=0;j<row.Length;j++)
            {
                
            }
        }
    }
}
// @lc code=end

