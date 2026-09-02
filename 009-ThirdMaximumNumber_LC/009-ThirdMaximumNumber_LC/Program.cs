class program
{
    public static int ThirdMax(int[] nums) { 
     Array.Sort(nums);
        HashSet<int> distinct = new HashSet<int>();
        for(int i=nums.Length - 1; i >= 0; i--)
        {
            distinct.Add(nums[i]);
            if (distinct.Count == 3)
            {
                return nums[i];
            }
        }return nums[nums.Length - 1];
    }
 static void Main(string[] args)
    {
        int[] nums = {2,2,3,1 };
        int result = ThirdMax(nums);
        Console.WriteLine(result); 
    }
}
