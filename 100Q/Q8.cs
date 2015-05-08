// 8. Nodes with Sum in a Binary Search Tree

// Problem: Given a binary search tree, please check whether there are two nodes in it whose sum equals a given value.

// Travel from smallest element and largest element, move the pointer accordingly
internal class BinaryTreeNode
{
    public int Value;
    public BinaryTreeNode Left;
    public BinaryTreeNode Right;

    public static bool hasTwoNodes(BinaryTreeNode root, int sum)
    {
        Stack<BinaryTreeNode> leftTree = new Stack<BinaryTreeNode>();
        Stack<BinaryTreeNode> rightTree = new Stack<BinaryTreeNode>();

        BinaryTreeNode node = root;
        while (node != null)
        {
            leftTree.Push(node);
            node = node.Left;
        }

        node = root;
        while (node != null)
        {
            rightTree.Push(node);
            node = node.Right;
        }

        BinaryTreeNode leftNode = GetNextMin(leftTree);
        BinaryTreeNode rightNode = GetNextMax(rightTree);

        while (leftNode != null && rightNode != null && leftNode != rightNode)
        {
            int currentSum = leftNode.Value + rightNode.Value;

            if (currentSum == sum)
            {
                return true;
            }
            else if (currentSum < sum)
            {
                leftNode = GetNextMin(leftTree);
            }
            else
            {
                rightNode = GetNextMax(rightTree);
            }
        }

        return false;
    }

    private static BinaryTreeNode GetNextMax(Stack<BinaryTreeNode> tree)
    {
        if (tree == null || tree.Count == 0)
        {
            return null;
        }

        BinaryTreeNode returnNode = tree.Pop();

        BinaryTreeNode leftNode = returnNode.Left;
        while (leftNode != null)
        {
            tree.Push(leftNode);
            leftNode = leftNode.Right;
        }

        return returnNode;
    }

    private static BinaryTreeNode GetNextMin(Stack<BinaryTreeNode> tree)
    {
        if (tree == null || tree.Count == 0)
        {
            return null;
        }

        BinaryTreeNode returnNode = tree.Pop();

        BinaryTreeNode rightNode = returnNode.Right;
        while (rightNode != null)
        {
            tree.Push(rightNode);
            rightNode = rightNode.Left;
        }

        return returnNode;
    }
}
