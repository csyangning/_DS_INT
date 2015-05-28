// https://leetcode.com/problems/flatten-binary-tree-to-linked-list/

// Given a binary tree, flatten it to a linked list in-place.
// 
// For example,
// Given
// 
//          1
//         / \
//        2   5
//       / \   \
//      3   4   6
// The flattened tree should look like:
//    1
//     \
//      2
//       \
//        3
//         \
//          4
//           \
//            5
//             \
//              6


/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution
{
    public void Flatten(TreeNode root)
    {
        if (root == null)
        {
            return;
        }

        TreeNode left = root.left;
        TreeNode right = root.right;

        Flatten(left);
        Flatten(right);

        TreeNode node = root.left;
        if (node != null)
        {
            while (node.right != null)
            {
                node = node.right;
            }
            node.right = root.right;
            root.left = null;
            root.right = left;
        }
    }
}