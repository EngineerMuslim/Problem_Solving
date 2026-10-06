using System;

class program
{
    public static int MinAddToMakeValid(string s)
    {
        int open = 0;
        int add = 0;

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '(')
            {
                open++;
            }
            else if (s[i] == ')')
            {
                if (open > 0)
                {
                    open--;
                }
                else
                {
                    add++;
                }
            }
        }

        return open + add;
    }

    public static void Main(string[] Args)
    {
        string s = "())";
        Console.WriteLine(MinAddToMakeValid(s));
    }
}
