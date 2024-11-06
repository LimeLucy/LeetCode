using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Q
{
	internal class Quest_020 : Quest
	{
		/**
		 * '(', ')', '{', '}', '[' 및 ']' 문자만 포함된 문자열 s가 주어졌을 때 입력 문자열이 유효한지 판단합니다. 
		 * 입력 문자열은 다음과 같은 경우에 유효합니다. 여는 대괄호는 같은 유형의 대괄호로 닫아야 합니다. 
		 * 여는 대괄호는 올바른 순서로 닫아야 합니다. 모든 닫는 대괄호에는 동일한 유형의 닫는 대괄호가 있어야 합니다.
		 * 
		 * Example 1:
			Input: s = "()"
			Output: true

			Example 2:
			Input: s = "()[]{}"
			Output: true

			Example 3:
			Input: s = "(]"
			Output: false

			Example 4:
			Input: s = "([])"
			Output: true
		 */

		public bool IsValid(string s)
		{
			Stack<char> stack = new Stack<char>();
			int sLen = s.Length;

			int i;
			bool isPop = false;
			for (i = 0; i < sLen; i++)
			{
				isPop = false;
				if (stack.Count > 0)
				{
					switch (stack.Peek())
					{
						case '(':
							isPop = (s[i] == ')');
							break;
						case '{':
							isPop = (s[i] == '}');
							break;
						case '[':
							isPop = (s[i] == ']');
							break;
					}
				}
				if (isPop)
					stack.Pop();
				else
					stack.Push(s[i]);
			}
			return stack.Count == 0;
		}
	}
}
