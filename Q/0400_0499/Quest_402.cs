using System;
using System.Collections.Generic;

namespace LeetCode.Q
{
	internal class Quest_402 : Quest
	{
		public override void Init()
		{
			//var ans = RemoveKdigits("10200", 1); // 200
			//var ans = RemoveKdigits("1432219", 3); // 1219
			var ans = RemoveKdigits("10200", 2); // 0
		}
		public string RemoveKdigits(string num, int k)
		{
			var stack = new Stack<char>();

			foreach (var c in num)
			{
				while (stack.Count != 0 && stack.Peek() > c && k > 0)
				{
					stack.Pop(); 
					k--;
				}
				stack.Push(c);
			}

			while (k > 0 && stack.Count > 0)
			{
				stack.Pop();
				k--;
			}

			var charArray = stack.ToArray();
			Array.Reverse(charArray);

			var str = new string(charArray).TrimStart('0');
			return string.IsNullOrEmpty(str) ? "0" : str;
		}
	}
}
