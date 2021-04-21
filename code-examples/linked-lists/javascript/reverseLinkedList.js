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
    // if ( !head ) return head;
    let pointer = head;
    // let aheadPointer = head.next;
    let newNext, oldNext, oldPointer = null;
    while ( pointer ) {
        newNext = oldPointer; // store null  
        oldNext = pointer.next // store [2,3,4,5]
        pointer.next = newNext; // 1 -> [2,3,4,5] => 1 → null 
        oldPointer = pointer; // store [1]
        pointer = oldNext; // move pointer to [2,3,4,5,]
    }
    return oldPointer;
};