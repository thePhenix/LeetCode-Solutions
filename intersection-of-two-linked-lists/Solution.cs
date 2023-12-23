// https://leetcode.com/problems/intersection-of-two-linked-lists

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB) {
        while(headA != null){
            ListNode temp = headB;
            while(temp != null){
                if(temp == headA){
                    return temp;
                }
                temp = temp.next;
            }
            headA = headA.next;
        }
        return null;
    }
}