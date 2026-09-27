public class TreeNode
{
   public int val;
    public TreeNode right;
    public TreeNode left;
    public TreeNode(int val=0, TreeNode right=null, TreeNode left=null)
    {
        this.val = val; this.right = right; this.left = left;
    }
}
class program
{
    public static int MinDepth(TreeNode root)
    {
        if (root == null) return 0;
        if(root.right == null) return MinDepth(root.left)+1;
        if(root.left == null)return MinDepth(root.right)+1;
        return Math.Min(MinDepth(root.right), MinDepth(root.left)) + 1;
    }
    public static void Main(string[] args)
    {
        TreeNode treenode = new TreeNode(3);
        treenode.left=new TreeNode(9);
        treenode.right=new TreeNode(20);
        treenode.right.left=new TreeNode(15);
        treenode.right.right = new TreeNode(7);
        Console.WriteLine(MinDepth(treenode));





    }
}