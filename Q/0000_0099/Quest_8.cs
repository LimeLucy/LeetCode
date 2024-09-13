using System;
using System.Text;

namespace LeetCode.Q
{
	internal class Quest_8 : Quest
	{
		public override void Init()
		{
			var result = MyAtoi("42");
			Console.WriteLine(result);
		}

		public int MyAtoi(string s)
		{
			int iIdx = 0;
			s = s.Trim();
			StringBuilder sb = new StringBuilder();
			foreach(var c in s)
			{
				if(Char.IsDigit(c) || (iIdx == 0 && (c == '-' || c == '+')))
				{
					sb.Append(c);
				}
				else
					break;
				iIdx++;
			}

			int iResult = 0;
			if(sb.Length > 0 && !(sb.Length == 1 && (sb[0] == '+' || sb[0] == '-')))
			{
				try
				{
					iResult = int.Parse(string.Concat(sb));
				}
				catch(Exception)
				{
					iResult = (sb[0] == '-') ? - 2147483648 : 2147483647;
				}
			}			
			return iResult;
		}
	}
}
