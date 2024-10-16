using System;
using System.Linq;

namespace LeetCode.Q
{
	internal class Quest_007 : Quest
	{
		#region 문제
		/*
		 * 부호화된 32비트 정수 x가 주어지면 자릿수를 반전하여 x를 반환합니다. 
		 * x를 반전하면 값이 부호 있는 32비트 정수 범위[-231, 231 - 1]를 벗어나면 0을 반환합니다. 
		 * 64비트 정수(부호 있거나 부호 없는)를 저장할 수 없는 환경이라고 가정합니다.
		 * 
		 * Example 1:
			Input: x = 123
			Output: 321in

		   Example 2:
			Input: x = -123
			Output: -321

		   Example 3:
			Input: x = 120
			Output: 21
		 */
		#endregion

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
