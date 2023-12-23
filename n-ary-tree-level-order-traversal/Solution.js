// https://leetcode.com/problems/n-ary-tree-level-order-traversal

/**
 * // Definition for a Node.
 * function Node(val,children) {
 *    this.val = val;
 *    this.children = children;
 * };
 */

/**
 * @param {Node|null} root
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
    
    if(root.children){
        root.children.forEach(child => {
            traverse(child, level + 1, result);
        })
    }
}

var levelOrder = function(root) {
    var result = [];
    traverse(root, 0, result);
    return result;
};