using System;
using System.Linq;

namespace LeetCode.Q
{
	internal class Quest_7 : Quest
	{
		public override void Init()
		{
			int a = Reverse(1534236469);
			Console.WriteLine(a);
		}

		public int Reverse(int x)
		{
			try
			{
				return int.Parse(string.Concat(Math.Abs(x).ToString().Reverse())) * (x < 0 ? -1 : 1);
			}
			catch(Exception)
			{
				return 0;
			}
		}
	}
}
