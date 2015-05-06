// 7. Closest Node in a Binary Search Tree

// Problem: Given a binary search tree and a value k, please find a node in the
// binary search tree whose value is closest to k.

internal class BinaryTreeNode
{
    public int value;
    public BinaryTreeNode Left;
    public BinaryTreeNode Right;

    public static BinaryTreeNode GetClosestNode(BinaryTreeNode root, int value)
    {
        if(root == null)
        {
            return null;
        }

        int minDistance = int.MaxValue;
        BinaryTreeNode closestNode = null;
        BinaryTreeNode node = root;

        while(node != null)
        {
            if(value > node.value)
            {
                int distance = value - node.value;

                if (distance < minDistance)
                {
                    minDistance = distance;
                    closestNode = node;
                }

                node = node.Right;
            }
            else if(value < node.value)
            {
                int distance = node.value - value;

                if (distance < minDistance)
                {
                    minDistance = distance;
                    closestNode = node;
                }

                node = node.Left;
            }
            else
            {
                return node;
            }
        }

        return closestNode;
    }
}
