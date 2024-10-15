using System;
using System.Collections.Generic;

namespace LeetCode.Q
{
	internal class Quest_402 : Quest
	{
		#region 문제
		/*
		 * 음수가 아닌 정수 num과 정수 k를 나타내는 문자열 num이 주어지면, num에서 k 자리를 제거한 후 가능한 가장 작은 정수를 반환합니다.
		 * 
		 * Example 1:
			Input: num = "1432219", k = 3
			Output: "1219"
			Explanation: Remove the three digits 4, 3, and 2 to form the new number 1219 which is the smallest.

		   Example 2:
			Input: num = "10200", k = 1
			Output: "200"
			Explanation: Remove the leading 1 and the number is 200. Note that the output must not contain leading zeroes.

		   Example 3:
			Input: num = "10", k = 2
			Output: "0"
			Explanation: Remove all the digits from the number and it is left with nothing which is 0.
		 */
		#endregion

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
