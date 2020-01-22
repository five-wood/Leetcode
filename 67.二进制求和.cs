/*
 * @lc app=leetcode.cn id=67 lang=csharp
 *
 * [67] 二进制求和
 */
using System;

// @lc code=start
public class Solution {
    public string AddBinary(string a, string b) {
        int L1=a.Length;
        int L2=b.Length;
        int maxLen=Math.Max(L1,L2);
        string result="";
        bool sign=false;
        char tmp='0';
        for(int i=0;i<maxLen;i++)
        {
            char c1=i<L1?a[L1-1-i]:'0';
            char c2=i<L2?b[L2-1-i]:'0';
            if(c1=='0'&&c2=='0')
            {
                tmp=sign?'1':'0';
                sign=false;
            }
            else if(c1=='1'&&c2=='1')
            {
                tmp=sign?'1':'0';
                sign=true;  
            }
            else
            {
                tmp=sign?'0':'1';
            }
            result=tmp.ToString()+result;
        }
        if(sign)
            result='1'+result;
        return result;
    }
}
// @lc code=end

