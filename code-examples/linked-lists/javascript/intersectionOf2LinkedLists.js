/**
 * https://leetcode.com/problems/intersection-of-two-linked-lists/
 * 
 * Definition for singly-linked list.
 * function ListNode(val) {
 *     this.val = val;
 *     this.next = null;
 * }
 */

/**
 * @param {ListNode} headA
 * @param {ListNode} headB
 * @return {ListNode}
 */
 var getIntersectionNode = function(headA, headB) {
    // define tail node variables and A, B counters
    let tailA = headA, tailB = headB;
    let A = 0, B = 0;
    // find lengths of A and B
    while (tailA && tailA.next) {
        tailA = tailA.next;
        A++
    }
    while (tailB && tailB.next) {
        tailB = tailB.next;
        B++
    }

    // return null if the tail nodes do not match
    if (tailA !== tailB) return null;
    
    let diff = B - A;

    // traverse the difference in the longer list
    if ( diff > 0 ) {
        for ( let i = 0 ; i < diff ; i++ ) {
            headB = headB.next;
        }
    } else
    if ( diff < 0 ) {
        for ( let i = diff ; i < 0 ; i++ ) {
            headA = headA.next;
        }
    }
    // find matches, return matched node, if not found, traverse together until match found
    while (headA) {
        if ( headA === headB ) {
            return headA;
        } else {
            headA = headA.next;
            headB = headB.next;
        }
    }
};