/**
 * Definition for singly-linked list.
 * struct ListNode {
 *     int val;
 *     ListNode *next;
 *     ListNode() : val(0), next(nullptr) {}
 *     ListNode(int x) : val(x), next(nullptr) {}
 *     ListNode(int x, ListNode *next) : val(x), next(next) {}
 * };
 */
class Solution {
public:
    bool isPalindrome(ListNode* head) {
        ListNode* x=head;
        int c=0;
        while(x!=NULL)
        {
          c++;
          x=x->next;
        }
        int *arr=new int[c];
        int i=0;
        ListNode* temp=head;
        while(temp!=NULL)
        {
          arr[i]=temp->val;
          temp=temp->next;
          i++;
        }
      ListNode *Temp=head;
      for(int j=i-1;j>=0;j--)
      {
        if(arr[j]==Temp->val)
        {   
            Temp=Temp->next;
        }
        else 
        {
            delete []arr;
            return false;
        }
      }
      delete []arr; 
      return true;
    }
};
