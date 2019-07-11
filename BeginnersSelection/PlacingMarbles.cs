using System;

class Program
{
    public static void Main(string[] args)
    {
        var str = Console.ReadLine();
        int cnt = 0;
        for (int i = 0; i < str.Length; ++i)
        {
            if (str[i] == '1')
            {
                ++cnt;
            }
        }
        MyLog(cnt);
    }

    private static void MyLog<T>(T s)
    {
        Console.WriteLine(s);
    }
}