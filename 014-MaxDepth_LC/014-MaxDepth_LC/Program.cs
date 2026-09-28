
using System;

class program
{
    public static int MaxDepth(string s)
    {
        int depth = 0;
        int maxDepth = 0;

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '(')
            {
                depth++;
                maxDepth = Math.Max(maxDepth, depth);
            }
            else if (s[i] == ')')
            {
                depth--;
            }
        }

        return maxDepth;
    }

    public static void Main(string[] args)
    {
        string s = "(1+(2*3)+((8)/4))+1";
        Console.WriteLine(MaxDepth(s));
    }
}