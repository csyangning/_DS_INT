//3. Paths with Specified Sum in Binary Tree
// Question: All nodes along children pointers from root to leaf nodes form a
// path in a binary tree. Given a binary tree and a number, please print out all
// of paths where the sum of all nodes value is same as the given number.

internal class BinaryTreeNode
{
    public int value;
    public BinaryTreeNode Left;
    public BinaryTreeNode Right;

    public static void FindPath(BinaryTreeNode root, int expectedSum)
    {
        if (root == null)
        {
            return;
        }

        LinkedList<BinaryTreeNode> path = new LinkedList<BinaryTreeNode>();
        FindPath(root, expectedSum, path, 0);
    }

    public static void FindPath(BinaryTreeNode node, int expectedSum, LinkedList<BinaryTreeNode> path, int currentSum)
    {
        path.AddLast(node);
        currentSum += node.value;

        if (node.Left == null && node.Right == null && currentSum == expectedSum)
        {
            foreach (var n in path)
            {
                Console.Write(n.value + "\t");
            }

            Console.WriteLine();
        }

        if (currentSum < expectedSum)
        {
            if (node.Left != null)
            {
                FindPath(node.Left, expectedSum, path, currentSum);
            }

            if (node.Right != null)
            {
                FindPath(node.Right, expectedSum, path, currentSum);
            }
        }

        path.RemoveLast();
    }
}
