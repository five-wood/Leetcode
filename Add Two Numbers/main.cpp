/**
 * Definition for singly-linked list.
 * struct ListNode {
 *     int val;
 *     ListNode *next;
 *     ListNode(int x) : val(x), next(NULL) {}
 * };
 */
class Solution {
public:
    ListNode* addTwoNumbers(ListNode* l1, ListNode* l2) {
        int tempDigit1 = 0, tempDigit2 = 0,execced=0;
        ListNode *templ1 = l1, *templ2 = l2,*resultList=NULL,*tempResult=NULL;
        while (templ1 != NULL || templ2 != NULL)
        {
            tempDigit1 = (templ1 != NULL) ? templ1->val : 0;
            templ1= (templ1 != NULL) ? templ1->next : NULL;
            tempDigit2= (templ2 != NULL) ? templ2->val : 0;
            templ2= (templ2 != NULL) ? templ2->next : NULL;
            int resultDigit = tempDigit1 + tempDigit2 + execced;
            execced = resultDigit > 9 ? 1 : 0;
            resultDigit = resultDigit % 10;
            if (tempResult != NULL)
            {
                tempResult->next = new ListNode(resultDigit);
                 tempResult=tempResult->next;
            }
            else
            {
                tempResult = new ListNode(resultDigit);
            }              
            if (resultList == NULL)
                resultList = tempResult;
           
        }
        if(execced)//最后的进位情况
            tempResult->next = new ListNode(execced);
        return resultList;
    }
};