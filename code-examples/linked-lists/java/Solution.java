/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     int val;
 *     ListNode next;
 *     ListNode(int x) { val = x; }
 * }
 */
class Solution {
    public ListNode addTwoNumbers(ListNode l1, ListNode l2) {
        //sentinel node to hold head
       ListNode dummyNode = new ListNode(0);
       ListNode result = dummyNode;
       ListNode first = l1;
       ListNode second = l2;
       int sum = 0;
       int carry = 0;
        while (first != null || second != null) {
            sum = (first != null ? first.val:0) + (second != null ?second.val:0) + carry;
            carry = sum/10;
            result.next = new ListNode(sum%10);
            result = result.next;
            first = first == null ?null : first.next;
            second = second == null ? null : second.next;
             
        } 
        if (carry != 0) {
            result.next = new ListNode(carry);
        }   
        return dummyNode.next;
    }
    
   
}
