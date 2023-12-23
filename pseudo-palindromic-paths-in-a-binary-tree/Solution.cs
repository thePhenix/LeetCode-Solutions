// https://leetcode.com/problems/pseudo-palindromic-paths-in-a-binary-tree

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
     public int count = 0;
        public void FindSolution(TreeNode root, Dictionary<int, int> mem, int level)
        {
            if (mem.ContainsKey(root.val))
            {
                mem[root.val]++;
            }
            else
            {
                mem[root.val] = 1;
            }

            if (root.left == null && root.right == null)
            {
                Calculate(mem, level);
            }

            if (root.left != null)
            {
                FindSolution(root.left, mem, level + 1);
            }
            

            if (root.right != null)
            {
                FindSolution(root.right, mem, level + 1);
            }

            mem[root.val]--;
            if (mem[root.val] == 0)
            {
                mem.Remove(root.val);
            }
        }

        public void Calculate(Dictionary<int, int> mem, int level)
        {
            if (level % 2 == 0)
            {
                foreach (var item in mem.Values)
                {
                    if (item % 2 == 1)
                    {
                        return;
                    }
                }
                count++;
            }
            else
            {
                bool isOddTaken = false;
                foreach (var item in mem.Values)
                {
                    if (item % 2 == 1)
                    {
                        if (isOddTaken)
                        {
                            return;
                        }

                        isOddTaken = true;
                    }
                }

                count++;
            }
        }

        public int PseudoPalindromicPaths(TreeNode root)
        {
            FindSolution(root, new Dictionary<int, int>(), 1);
            return count;
        }
}