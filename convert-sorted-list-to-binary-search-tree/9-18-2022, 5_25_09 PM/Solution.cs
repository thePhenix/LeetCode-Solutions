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
    public TreeNode CreateBST(int[] nums, int start, int end){
        if(start > end){
            return null;
        }
        
        var center = (start + end) / 2;
        
        var root = new TreeNode(nums[center]);
        
        root.left = CreateBST(nums, start, center - 1);
        root.right = CreateBST(nums, center + 1, end);
        
        return root;
    }
    
    public TreeNode SortedListToBST(ListNode head) {
        var arr = new List<int>();
        while(head != null){
            arr.Add(head.val);
            head = head.next;
        }
        
        var nums = arr.ToArray();
        var root = CreateBST(nums, 0, nums.Length - 1);
        return root;
    }
}