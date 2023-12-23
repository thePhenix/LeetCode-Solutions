// https://leetcode.com/problems/palindrome-linked-list

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
    public bool IsPalindrome(ListNode head) {
        var list = new List<int>();
        
        while(head != null){
            list.Add(head.val);
            head = head.next;
        }
        
        var i = 0;
        var j = list.Count() - 1;
        while(i < j){
            if(list[i++] != list[j--]){
                return false;
            }
        }
        
        return true;
    }
}