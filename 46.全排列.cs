/*
 * [46] 全排列
 
 */
using System;
using System.Collections.Generic;
// @lc code=start
public class Solution {

    /*法一：递归法
    对于n-1个数形成的list集合，向每个元素中从左往右插入第n个数，
    将此过程中产生的新list添加到集合，即可获得n个数产生的list集合
    */
    public IList<IList<int>> LastPermute(IList<IList<int>> result,int[] nums,int len)
    {
        if(len>nums.Length)
            return null;
        if(len==1)
        {
            IList<int> element=new List<int>();
            element.Add(nums[0]);
            result.Add(element);
            return result;
        }
        int curNum=nums[len-1];

        IList<IList<int>> last=LastPermute(result,nums,len-1);
        int lastCount=last.Count;
        for(int i=0;i<lastCount;i++)
        {
            IList<int>element=last[i];
            element.Add(curNum);   
            int time=0;
            while(time<element.Count-1)
            {
                IList<int> newElementTmp=new List<int>();
                for(int j=0;j<element.Count-1;j++)
                {
                    if(j==time)
                        newElementTmp.Add(curNum);
                    newElementTmp.Add(element[j]);
                }
                last.Add(newElementTmp);
                time++;
            } 
        }
        return last;
    }
    public IList<IList<int>> Permute(int[] nums) {
        // IList<IList<int>> result=new List<IList<int>>();
        // result=LastPermute(result,nums,nums.Length);
        // return result;

        IList<IList<int>> result=new List<IList<int>>();
        bool[] usedArr=new bool[nums.Length];
        result=LastPermute(List<int>(),result,usedArr,nums,nums.Length,0);
        return result;

    }

    //法二：回溯法
    public IList<IList<int>> genPermuteBackTracking(List<int> path,IList<IList<int>> result,bool[] usedArr,int[] nums,int len,int curCount)
    {
        if(curCount==len)
        {
            result.Add(path);
            path=new List<int>();
        }
        for(int i=0;i<len;i++)
        {
            if(!usedArr[curCount])
            {

            }
        }
        
    }

}
// @lc code=end

