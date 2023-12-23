// https://leetcode.com/problems/convert-sorted-list-to-binary-search-tree

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
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public TreeNode ConvertBST(ListNode head, ListNode tail){
        if(head == tail){
            return null;
        }
        
        ListNode fast = head;
        ListNode slow = head;
        
        while(fast != tail){
            fast = fast.next;
            if(fast != tail){
                fast = fast.next;
                slow = slow.next;
            }
        }
        
        var root = new TreeNode(slow.val);
        root.left = ConvertBST(head, slow);
        root.right = ConvertBST(slow.next, tail);
        
        return root;
    }
    
    public TreeNode SortedListToBST(ListNode head) {
        return ConvertBST(head, null);
    }
}