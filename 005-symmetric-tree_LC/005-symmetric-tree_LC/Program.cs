public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}
class program
{
    public static bool IsSymmetric(TreeNode root)
    {
        if (root == null) return true;
        return IsMirror(root.left, root.right);
    }
    private static bool IsMirror(TreeNode left, TreeNode rigth)
    {
        if (left == null && rigth == null) return true;
        if (left == null || rigth == null) return false;
        if(left.val != rigth.val) return false;
        return IsMirror(left.left, rigth.right) && IsMirror(left.right, rigth.left);
    }
    

    static void Main(string[] args)
    {
        TreeNode root = new TreeNode(1);
        root.left = new TreeNode(2);
        root.right = new TreeNode(2);
        root.left.left = new TreeNode(3);
        root.left.right = new TreeNode(4);
        root.right.left = new TreeNode(4);
        root.right.right = new TreeNode(3);
        bool result = IsSymmetric(root);
        Console.WriteLine(result); 
    }
}
