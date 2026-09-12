using System.Security.Principal;

class program
{
    public static bool ContainsNearbyDuplicate(int[] nums, int k)
    {
        HashSet<int> set = new HashSet<int>();
        for(int i = 0; i < nums.Length; i++)
        {
            if (set.Contains(nums[i]))
                return true;
            set.Add(nums[i]);
            if (set.Count > k)
            {
                set.Remove(nums[i - k]);
            }

        }
        return false;
    }
    public static void Main (string[] Args)
    {
        int[] nums = { 1, 2, 3, 1 };
        int k = 3;
        Console.WriteLine(ContainsNearbyDuplicate(nums, k));
    }
}
