/**
 * https://leetcode.com/problems/reverse-linked-list/
 * 
 * Definition for singly-linked list.
 * function ListNode(val, next) {
 *     this.val = (val===undefined ? 0 : val)
 *     this.next = (next===undefined ? null : next)
 * }
 */
/**
 * @param {ListNode} head
 * @return {ListNode}
 */
 var reverseList = function(head) {
    let pointer = head;
    let oldPointer = null;
    while ( pointer ) {        
        [pointer.next, oldPointer, pointer] = 
        [oldPointer, pointer, pointer.next]        
    }
    return oldPointer;
}
