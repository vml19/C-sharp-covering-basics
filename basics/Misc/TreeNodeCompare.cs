namespace ca_basics
{
    class BinaryTree
    {
        public static bool Compare(TreeNode a, TreeNode b)
        {
            if (a == null && b == null)
                return true;

            if ((a == null && b != null) || (a != null && b == null))
                return false;

            return a.val == b.val && Compare(b.left, a.left) && Compare(a.right, b.right);
        }

    }

    class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
    }
}
