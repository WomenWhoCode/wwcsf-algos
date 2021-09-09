/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     int val;
 *     ListNode next;
 *     ListNode() {}
 *     ListNode(int val) { this.val = val; }
 *     ListNode(int val, ListNode next) { this.val = val; this.next = next; }
 * }
 */
//===================================
// Iterative Approach 
//===================================
// Time Complexity : O(n)
// Space Complexity : O(1)
class Solution {
    public ListNode reverseList(ListNode head) {
        ListNode prev = null;
        ListNode curr = head;
        while (curr != null){
            ListNode n1 = curr.next;
            curr.next = prev;
            
            // Shift
            prev = curr;
            curr = n1;
        }
        return prev;
    }
}