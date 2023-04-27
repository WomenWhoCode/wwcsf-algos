/**
 * Definition for singly-linked list.
 * class ListNode {
 *     int val;
 *     ListNode next;
 *     ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
// Time Complexity : O(n)
// Space Complexity : O(1)
// Reference : https://www.codingninjas.com/blog/2020/09/09/floyds-cycle-detection-algorithm/
public class Solution {
    public boolean hasCycle(ListNode head) {
    if(head==null) return false;
    ListNode slow = head;
    ListNode fast = head.next;
    while (slow != fast){
        if (fast == null || fast.next == null) {
            return false;
        }
        slow = slow.next;
        fast = fast.next.next;
    }
    return true;
 }
}