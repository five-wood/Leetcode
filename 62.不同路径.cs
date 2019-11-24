/*
 * @lc app=leetcode.cn id=62 lang=csharp
 *
 * [62] 不同路径
 */

// @lc code=start
public class Solution {
   int[][] recordMap;
    public int UniquePaths(int m, int n) {
        recordMap=new int[m][];
        for(int i=0;i<m;i++)
            recordMap[i]=new int[n];
        recordMap[0][0]=0;
        for(int x=0;x<m;x++)
            recordMap[x][0]=1;
        for(int y=0;y<n;y++)
            recordMap[0][y]=1;
        return RecordMapInfo(m-1,n-1);
    }
    public int RecordMapInfo(int x,int y)
    {
        if(recordMap[x][y]!=0 ||x==0||y==0)
            return recordMap[x][y];
        recordMap[x][y]=RecordMapInfo(x-1,y)+RecordMapInfo(x,y-1);
        return recordMap[x][y];
    }
}
// @lc code=end

