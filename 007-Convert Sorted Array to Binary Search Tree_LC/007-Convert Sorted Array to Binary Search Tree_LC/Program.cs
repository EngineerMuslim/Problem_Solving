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
    public static TreeNode SortedArrayToBST(int[] nums)
    {
        if (nums == null || nums.Length == 0)
            return null;
        return BuildBST(nums, 0, nums.Length - 1);
    }
    public static TreeNode BuildBST(int[] nums, int left, int right)
    {
        if (left > right)
            return null;
        int mid = left + (right - left) / 2;
        TreeNode node = new TreeNode(nums[mid]);
        node.left = BuildBST(nums, left, mid - 1);
        node.right = BuildBST(nums, mid + 1, right);
        return node;
    }
    static void Main(string[] args)
    {
        int[] nums = { -10, -3, 0, 5, 9 };
        TreeNode root = SortedArrayToBST(nums);
    Console.WriteLine(root.val);
    }
}