/*
解题关键：
1、排序
2、双指针
3、去重
*/
using System.Collections.Generic;
public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        List<int>sortList=new List<int>();
        for(int i=0;i<nums.Length;i++)
            sortList.Add(nums[i]);
        sortList.Sort((a,b)=>{
            if(a<b)
                return -1;
            else if(a==b)
                return 0;
            else
                return 1;
            }
        );
        IList<IList<int>> result=new List<IList<int>>();
        for(int i=0;i<sortList.Count;i++)
        {
            if(i>0&&sortList[i-1]==sortList[i])
                continue;
            int first=sortList[i];
            int Lindex=i+1;
            int Rindex=sortList.Count-1;
            while(Lindex<Rindex)
            {
                int sum=first+sortList[Lindex]+sortList[Rindex];
                if(sum==0)
                {
                    IList<int>tmp=new List<int>();
                    tmp.Add(first);
                    tmp.Add(sortList[Lindex]);
                    tmp.Add(sortList[Rindex]);
                    result.Add(tmp);
                    while(Rindex>Lindex&&sortList[Rindex]==sortList[--Rindex])
                    ;
                    while(Lindex<Rindex&&sortList[Lindex]==sortList[++Lindex])
                    ;
                }
                else if (sum>0)
                    Rindex--;
                else
                    Lindex++;
            }
        }
        return result.ToList();
    }
}
// @lc code=end

