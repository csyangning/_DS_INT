    internal class BinaryTreeNode
    {
        public int value;
        public BinaryTreeNode Left;
        public BinaryTreeNode Right;

        public static BinaryTreeNode Convert(BinaryTreeNode root)
        {
            BinaryTreeNode lastNode = null;
            ConvertNode(root, ref lastNode);

            while (root.Left != null)
            {
                root = root.Left;
            }

            return root;
        }

        public static void ConvertNode(BinaryTreeNode node, ref BinaryTreeNode lastNode)
        {
            if (node == null)
            {
                return;
            }

            if (node.Left != null)
            {
                ConvertNode(node.Left, ref lastNode);
            }

            node.Left = lastNode;

            if (lastNode != null)
            {
                lastNode.Right = node;
            }

            lastNode = node;


            if (node.Right != null)
            {
                ConvertNode(node.Right, ref lastNode);
            }
        }
    }
