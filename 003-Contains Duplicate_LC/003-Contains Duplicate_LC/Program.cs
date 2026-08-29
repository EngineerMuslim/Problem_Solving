
class program
{
    public static bool ContainsDuplicate(int[] nums)
    {
        HashSet<int> set = new HashSet<int>();
        foreach (int num in nums)
        {
            if (set.Contains(num))
            {
                return true;
            }
            set.Add(num);
        }return false;
    }
    static void Main(string[] args)
    {
        int[] nums = { 1, 2, 3, 4, 5, 1 };
        bool result = ContainsDuplicate(nums);
        Console.WriteLine(result); 
    }
}