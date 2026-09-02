class program
{
    public static bool UniformArray(int[] nums1)
    {
        bool hasEven = false;
        bool hasOdd = false;
        foreach (int num in nums1)
        {
            if (num % 2 == 0)
                hasEven = true;
            else
                hasOdd = true;
        }
        return true;
    }

    static void Main(string[] args)
    {
        int[] nums = { 2, 3};

Console.WriteLine("UniformArray: " + UniformArray(nums));
    }
}