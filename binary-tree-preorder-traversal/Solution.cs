// https://leetcode.com/problems/binary-tree-preorder-traversal

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
    public void Traverse(TreeNode root, List<int> result){
        if(root == null){
            return;
        }
        
        result.Add(root.val);
        Traverse(root.left, result);
        Traverse(root.right, result);
    }
    
    public IList<int> PreorderTraversal(TreeNode root) {
        var result = new List<int>();
        Traverse(root, result);
        return result;
    }
}