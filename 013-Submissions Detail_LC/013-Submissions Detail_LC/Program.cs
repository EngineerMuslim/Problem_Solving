using System.Security.Cryptography.X509Certificates;

class program
{
    public static int SmallestIndex(int[] nums)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            int num= nums[i];
            int sum = 0;
            while (num > 0)
            {
                sum += num % 10;
                num/=10;
            }
            if(sum==i) return i;
        }return -1;
    }
    public static void Main  (string[] args)
    {
        int[] nums = { 1, 10, 11 };
        Console.WriteLine(SmallestIndex(nums));
    }
}