// https://leetcode.com/problems/symmetric-tree

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
 * @return {boolean}
 */
var prepare = (root, mem , level) => {
    if(!mem[level]){
        mem[level] = [];
    }
    
    if(!root){
        mem[level].push(-100000);
        return;
    }
    
    mem[level].push(root.val);
    prepare(root.left, mem, level + 1);
    prepare(root.right, mem, level + 1);
    
    
}
var isSymmetric = function(root) {
    let mem = [];
    prepare(root, mem, 0);
    let symmetric = true;
    mem.forEach(list => {
        var j = list.length - 1;
       for(var i = 0; i < j; i++){
           if(list[i] !== list[j--]){
               symmetric = false;
               return false;
           }
       } 
    });
    return symmetric;
};