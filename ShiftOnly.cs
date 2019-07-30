using System;

class Program
{
	public static void Main(string[] args)
	{
		var num = int.Parse(Console.ReadLine());
		string[] ary = Console.ReadLine().Split(' ');
		var result = 0;
		var finished = false;
		while (!finished)
		{
			for (var i = 0; i < num; ++i)
			{
				var n = long.Parse(ary[i]);
				if (n % 2 == 0)
				{
					ary[i] = (n / 2).ToString();
				}
				else
				{
					finished = true;
					break;
				}
			}
			if (!finished)
				++result;
		}
		Console.WriteLine(result);
	}
}
