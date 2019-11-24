/*
 * @lc app=leetcode.cn id=64 lang=csharp
 *
 * [64] 最小路径和
 */

// @lc code=start
using System;
public class Solution {
     int[][] recordMap;
     public int MinPathSum(int[][] grid) {
         int m=grid.Length;
         int n=grid[0].Length;
        recordMap=new int[m][];
        for(int i=0;i<m;i++)
            recordMap[i]=new int[n];
        recordMap[0][0]=grid[0][0];
        for(int x=1;x<m;x++)
            recordMap[x][0]=recordMap[x-1][0]+grid[x][0];
        for(int y=1;y<n;y++)
            recordMap[0][y]=recordMap[0][y-1]+grid[0][y];
        return RecordMapInfo(m-1,n-1,grid);
    }
    public int RecordMapInfo(int x,int y,int[][] grid)
    {
        if(recordMap[x][y]!=0 || x==0||y==0)
            return recordMap[x][y];
        recordMap[x][y]=Math.Min(RecordMapInfo(x-1,y,grid),RecordMapInfo(x,y-1,grid))+grid[x][y];
        return recordMap[x][y];
    }
}
// @lc code=end

