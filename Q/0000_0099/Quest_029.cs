using System;

namespace LeetCode.Q
{
	internal class Quest_029 : Quest
	{
		#region 문제
		/*
		 * 두 정수의 나눗셈과 나눗셈이 주어지면 곱셈, 나눗셈, 모둠 연산자를 사용하지 않고 두 정수를 나눕니다. 
		 * 정수 나누기는 0을 향해 잘려야 하며, 이는 분수 부분을 잃는다는 것을 의미합니다. 
		 * 예를 들어 8.345는 8로 잘리고 -2.7335는 -2로 잘립니다. 나눗셈을 제수로 나눈 후 몫을 반환합니다. 
		 * 참고: 32비트 부호 정수 범위 내에서만 정수를 저장할 수 있는 환경을 다루고 있다고 가정합니다: 
		 * [-231, 231 - 1]. 이 문제에서 지수가 231 - 1보다 엄격하게 크면 231 - 1을 반환하고, 지수가 -231보다 엄격하게 작으면 -231을 반환합니다.
		 * Example 1:
			Input: dividend = 10, divisor = 3
			Output: 3
			Explanation: 10/3 = 3.33333.. which is truncated to 3.
		   Example 2:
			Input: dividend = 7, divisor = -3
			Output: -2
			Explanation: 7/-3 = -2.33333.. which is truncated to -2.
		 */
		#endregion
		public override void Init()
		{
			var ans = Divide(-2147483648, 2);
			Console.WriteLine(ans);
		}

		public int Divide(int dividend, int divisor)
		{
			if (dividend == int.MinValue && divisor == -1)
				return int.MaxValue;

			bool negative = (dividend < 0) ^ (divisor < 0);

			long absDividend = Math.Abs((long)dividend);
			long absDivisor = Math.Abs((long)divisor);

			int result = 0;

			while (absDividend >= absDivisor)
			{
				long temp = absDivisor, multiple = 1;
				while (absDividend >= (temp << 1))
				{
					temp <<= 1;
					multiple <<= 1;
				}
				absDividend -= temp;
				result += (int)multiple;
			}

			return negative ? -result : result;
		}
	}
}
