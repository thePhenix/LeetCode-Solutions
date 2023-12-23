// https://leetcode.com/problems/binary-tree-pruning

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
    public bool FindSol(TreeNode root, bool res){
        if (root == null)
            {
                return res;
            }

            if (root.val == 1)
            {
                res = true;
            }
        
            var leftTree = FindSol(root.left, false);
            var rightTree = FindSol(root.right, false);

            res = leftTree || rightTree || res;
        
            if(!leftTree){
                root.left = null;
            }
        
            if(!rightTree){
                root.right = null;
            }

            return res;
    }
    
    public TreeNode PruneTree(TreeNode root) {
        
        var res = FindSol(root, false);
        if(!res){
            return null;
        }
        return root;
    }
}