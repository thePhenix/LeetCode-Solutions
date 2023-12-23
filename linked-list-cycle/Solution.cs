// https://leetcode.com/problems/linked-list-cycle

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
    public bool HasCycle(ListNode head) {
        if(head == null || head.next == null){
            return false;
        }
        var slow = head;
        var fast = head.next.next;

        while(fast != null && fast.next != null)
        {
            if(slow == fast){
                return true;
            }
            slow = slow.next;
            fast = fast.next.next;
        }
        return false;
    }
}