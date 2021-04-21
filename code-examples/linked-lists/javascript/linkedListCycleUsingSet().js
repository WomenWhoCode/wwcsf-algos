/**
 * https://leetcode.com/problems/linked-list-cycle
 * 
 * Definition for singly-linked list.
 * function ListNode(val) {
 *     this.val = val;
 *     this.next = null;
 * }
 */

/**
 * @param {ListNode} head
 * @return {boolean}
 */
 var hasCycle = function(head) {
    if ( head === null ) return false;
    let set = new Set([]);
    let node = head;
    while ( node.next ) {
        set.add( node );
        if ( set.has( node.next ) ) return true; 
        node = node.next
    }
    return false;
};