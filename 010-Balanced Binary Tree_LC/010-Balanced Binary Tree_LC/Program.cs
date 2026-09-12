using System.Diagnostics.Contracts;

public class TreeNode
{
    public int value;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int value = 0, TreeNode left = null, TreeNode right = null)
    {
        this.value = value;
        this.left = left;
        this.right = right;
    }
}
class program
{
    public static bool ISBalanced(TreeNode root)
    {
        return GetHeight(root) != -1;
    }
public static int GetHeight(TreeNode root)
    {
        if (root == null)
            return 0;
        int leftHeight = GetHeight(root.left);
        if (leftHeight == -1)
            return -1;
        int rightHeight = GetHeight(root.right);
        if (rightHeight == -1)
            return -1;
        if (Math.Abs(leftHeight - rightHeight) > 1)
            return -1;
        return Math.Max(leftHeight, rightHeight) + 1;
    }
    static void Main(string[] args)
    {
        TreeNode root = new TreeNode(1);
        root.left = new TreeNode(2);
        root.right = new TreeNode(3);
        root.left.left = new TreeNode(4);
        root.left.right = new TreeNode(5);
        root.right.right = new TreeNode(6);
        bool isBalanced = ISBalanced(root);
        Console.WriteLine($"Is the binary tree balanced? {isBalanced}");
    }
}
