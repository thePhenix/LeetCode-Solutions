// https://leetcode.com/problems/linked-list-cycle-ii

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
    public ListNode DetectCycle(ListNode head) {
        var set = new HashSet<ListNode>();
        while(head != null){
            if(!set.Add(head)){
                return head;
            }
            head = head.next;
        }

        return null;
    }
}