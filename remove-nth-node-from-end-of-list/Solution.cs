// https://leetcode.com/problems/remove-nth-node-from-end-of-list

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        var current = head;
        ListNode prevNode = null;
        
        var i = 1;
        while(current != null){
            i++;
            current=current.next;
        }
        
        i = i-n;
        
        current = head;
        var j = 1;
        while(current != null){
            if(j == i){
                if(prevNode == null){
                    return current.next;
                }
                prevNode.next = current.next;
                break;
            }
            j++;
            prevNode = current;
            current = current.next;
        }
        
        return head;
    }
}