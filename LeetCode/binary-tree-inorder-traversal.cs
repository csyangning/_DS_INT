//  https://leetcode.com/problems/binary-tree-inorder-traversal/
//
//  Given a binary tree, return the inorder traversal of its nodes' values.
//
//  For example:
//  Given binary tree {1,#,2,3},
//     1
//      \
//       2
//      /
//     3
//  return [1,3,2].

/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    public IList<int> InorderTraversal(TreeNode root) {
        List<int> result = new List<int>();

        Travel(root, result);
        return result;
    }

    private void Travel(TreeNode root, List<int> result)
    {
        if(root == null)
        {
            return;
        }

        Travel(root.left, result);
        result.Add(root.val);
        Travel(root.right, result);
    }
}
