// https://leetcode.com/problems/maximum-depth-of-binary-tree

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
    public int FindSolution(TreeNode root, int level){
        if(root == null){
            return level - 1;
        }
        
        var leftHeight = FindSolution(root.left, level + 1);
        var rightHeight = FindSolution(root.right, level + 1);
        
        return leftHeight > rightHeight ? leftHeight : rightHeight;
    }
    
    public int MaxDepth(TreeNode root) {
        var height = FindSolution(root, 1);
        return height;
    }
}