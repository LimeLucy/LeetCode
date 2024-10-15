using System;
using System.Text;

namespace LeetCode.Q
{
	internal class Quest_008 : Quest
	{
		#region 문제
		/*
		 * 문자열을 32비트 부호 있는 정수로 변환하는 myAtoi(문자열 s) 함수를 구현합니다. myAtoi(문자열 s)의 알고리즘은 다음과 같습니다: 공백: 선행 공백(" ")은 무시합니다. 
		 * 부호: 양수가 없다고 가정하고 다음 문자가 '-' 또는 '+'인지 확인하여 부호를 결정합니다. 
		 * 변환: 숫자가 아닌 문자가 발견되거나 문자열의 끝에 도달할 때까지 선행 0을 건너뛰는 방식으로 정수를 읽습니다. 
		 * 읽은 자릿수가 없으면 결과는 0이 됩니다. 반올림합니다: 정수가 32비트 부호 있는 정수 범위[-231, 231 - 1]를 벗어난 경우 정수를 반올림하여 범위 내에 유지합니다. 
		 * 구체적으로 -231보다 작은 정수는 -231로 반올림하고, 231 - 1보다 큰 정수는 231 - 1로 반올림해야 합니다. 최종 결과로 정수를 반환합니다.
		 * 
		 * Example 1:
			Input: s = "42"
			Output: 42
			Explanation:
			The underlined characters are what is read in and the caret is the current reader position.
			Step 1: "42" (no characters read because there is no leading whitespace)
					 ^
			Step 2: "42" (no characters read because there is neither a '-' nor '+')
					 ^
			Step 3: "42" ("42" is read in)
					   ^
		  Example 2:
			Input: s = " -042"
			Output: -42
			Explanation:
			Step 1: "   -042" (leading whitespace is read and ignored)
						^
			Step 2: "   -042" ('-' is read, so the result should be negative)
						 ^
			Step 3: "   -042" ("042" is read in, leading zeros ignored in the result)
		 */
		#endregion

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
