/**
 * https://leetcode.com/problems/delete-node-in-a-linked-list/
 * 
 * Definition for singly-linked list.
 * function ListNode(val) {
 *     this.val = val;
 *     this.next = null;
 * }
 */
/**
 * @param {ListNode} node
 * @return {void} Do not return anything, modify node in-place instead.
 */
 var deleteNode = function(node) {
    //   5       [1,9]             1             [9]
    [node.val, node.next] = [node.next.val, node.next.next];
};