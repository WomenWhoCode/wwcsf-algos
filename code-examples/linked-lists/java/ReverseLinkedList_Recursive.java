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
// Recursive Approach 
//===================================
// Time Complexity : O(n)
// Space Complexity : O(n)

class Solution {

    public ListNode reverseList(ListNode head) {
        ListNode finalHead;
        if (head == null || head.next == null) return head;
        else {
            finalHead = reverseList(head.next);
            ListNode nextNode = head.next;
            nextNode.next = head;
            head.next = null;
        }
        return finalHead;
    }
}