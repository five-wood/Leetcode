/*
 * [19] 删除链表的倒数第N个节点
 解题思路：双指针，间隔N个节点
 */

// @lc code=start
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        /* 写法一：不添加新节点
        if(head==null || (n>=1 && head.next==null))
            return null;
        ListNode prePoint=head;
        ListNode nextPoint=head;
        while(prePoint.next!=null)
        {
            prePoint=prePoint.next;
            if(n>0)
                n--;
            else
                nextPoint=nextPoint.next;
        }
        if(n==1) //刚好移除链表头部第一个节点
            head=head.next;
        else
            nextPoint.next=nextPoint.next.next;

        return head;
        */
        
        //写法二：添加新节点
        ListNode temp=new ListNode(0);
        temp.next=head;
        ListNode prePoint=temp;
        ListNode nextPoint=temp;
        while(prePoint.next!=null)
        {
            prePoint=prePoint.next;
            if(n>0)
                n--;
            else
                nextPoint=nextPoint.next;
        }
        nextPoint.next=nextPoint.next.next;
        return temp.next;
    }
}
// @lc code=end

