using System;
using System.Collections.Generic;

class Program
{
    public static IList<IList<int>> Subsets(int[] nums)
    {
        List<IList<int>> result = new List<IList<int>>();
        List<int> current = new List<int>();

        Backtrack(0);

        return result;

        void Backtrack(int start)
        {
            result.Add(new List<int>(current));

            for (int i = start; i < nums.Length; i++)
            {
                current.Add(nums[i]);

                Backtrack(i + 1);

                current.RemoveAt(current.Count - 1);
            }
        }
    }

    static void Main(string[] args)
    {
        int[] nums = { 1, 2, 3 };

        var result = Subsets(nums);

        foreach (var item in result)
        {
            Console.Write("[");

            foreach (var num in item)
            {
                Console.Write(num + " ");
            }

            Console.WriteLine("]");
        }
    }
}