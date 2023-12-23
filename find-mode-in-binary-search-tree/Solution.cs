// https://leetcode.com/problems/find-mode-in-binary-search-tree

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
    Dictionary<int, int> mem;
    int maxVal = int.MinValue;
    public void FindSolution(TreeNode root){
        if(root == null){
            return;
        }
        
        if(mem.ContainsKey(root.val)){
            mem[root.val]++;
        }else{
            mem[root.val] = 1;
        }
        
        if(mem[root.val] > maxVal){
            maxVal = mem[root.val];
        }
        
        FindSolution(root.left);
        FindSolution(root.right);

    }
    
    public int[] FindMode(TreeNode root) {
        mem = new Dictionary<int,int>();
        FindSolution(root);
        var solutions = new List<int>();
        foreach(var item in mem){
            if(item.Value == maxVal){
                solutions.Add(item.Key);
            }
        }
        return solutions.ToArray();
    }
}