// https://leetcode.com/problems/n-ary-tree-preorder-traversal

/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> children;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val,IList<Node> _children) {
        val = _val;
        children = _children;
    }
}
*/

public class Solution {
    public IList<int> Traverse(Node root, List<int> result){
        if(root == null){
            return result;
        }
        
        result.Add(root.val);
        
        if(root.children != null){
            foreach(var child in root.children){
                Traverse(child, result);
            }
        }
        
        return result;
    }
    
    public IList<int> Preorder(Node root) {
        var result = new List<int>();
        return Traverse(root, result);
    }
}