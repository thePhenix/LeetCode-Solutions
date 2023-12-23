// https://leetcode.com/problems/binary-tree-level-order-traversal

/**
 * Definition for a binary tree node.
 * function TreeNode(val, left, right) {
 *     this.val = (val===undefined ? 0 : val)
 *     this.left = (left===undefined ? null : left)
 *     this.right = (right===undefined ? null : right)
 * }
 */
/**
 * @param {TreeNode} root
 * @return {number[][]}
 */
var traverse = (root, level,result) => {
    if(!root){
        return;
    }
    
    if(!result[level]){
        result[level] = [];
    }
    
    result[level].push(root.val);
    
    traverse(root.left, level + 1, result);        
    traverse(root.right, level + 1, result);
}

var levelOrder = function(root) {
    var result = [];
    traverse(root, 0, result);
    return result;
};