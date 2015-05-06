internal class BinaryTreeNode
{
    public int value;
    public BinaryTreeNode Left;
    public BinaryTreeNode Right;

    public static bool isBST(BinaryTreeNode root)
    {
        return isBST(root, int.MinValue, int.MaxValue);
    }

    public static bool isBST(BinaryTreeNode node, int min, int max)
    {
        if(node == null)
        {
            return true;
        }

        if(node.value > max || node.value < min)
        {
            return false;
        }

        return isBST(node.Left, min, node.value) && isBST(node.Right, node.value, max);
    }
}
