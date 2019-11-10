using System.Collections.Generic;
using System;
public class Solution {
    public int NumRabbits(int[] answers) {
        //记录下回答相同数字的兔子有多少只
        Dictionary<int,int> recordDict=new Dictionary<int, int>();
        for(int i=0;i<answers.Length;i++)
        {
            int answer=answers[i];
            if(!recordDict.ContainsKey(answer))
                recordDict.Add(answer,0);
            //Console.WriteLine("______answer:"+answer);
            recordDict[answer]=recordDict[answer]+1;
        }
        int result=0;
        foreach(var keyValue in recordDict)
        {
            int answer=keyValue.Key; 
            int rabbitNum=keyValue.Value; 
            int magnification= answer==0? rabbitNum : (int)Math.Ceiling((float)rabbitNum/(answer+1));
            Console.WriteLine(answer+" "+magnification);          
            result+=(answer+1)*magnification;
        }
        return result;
    }
}
// @lc code=end

