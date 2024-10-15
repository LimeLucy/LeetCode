using System.Linq;

namespace LeetCode.Q
{
	internal class Quest_2028 : Quest
	{
		#region 문제
		/*
		 * 각 면에 1부터 6까지 번호가 매겨진 n + m개의 6면 주사위 굴림에 대한 관찰이 있는데, n개의 관찰이 사라지고 m개의 주사위 굴림에 대한 관찰만 남았습니다. 
		 * 다행히도 n + m 주사위의 평균값도 계산했습니다. 길이 m의 정수 배열 롤이 주어지며, 롤[i]는 째 관측값입니다. 또한 두 개의 정수 평균과 n이 주어집니다. 
		 * n + m 롤의 평균값이 정확히 평균이 되도록 누락된 관측값을 포함하는 길이 n의 배열을 반환합니다. 
		 * 유효한 답이 여러 개 있으면 그 중 하나를 반환합니다. 이러한 배열이 존재하지 않으면 빈 배열을 반환합니다. 
		 * k 숫자 집합의 평균값은 숫자의 합을 k로 나눈 값입니다. 평균은 정수가므로 n + m 롤의 합은 n + m으로 나눌 수 있어야 합니다.
		 * 
			Example 1:
				Input: rolls = [3,2,4,3], mean = 4, n = 2
				Output: [6,6]
				Explanation: The mean of all n + m rolls is (3 + 2 + 4 + 3 + 6 + 6) / 6 = 4.

			Example 2:
				Input: rolls = [1,5,6], mean = 3, n = 4
				Output: [2,3,2,2]
				Explanation: The mean of all n + m rolls is (1 + 5 + 6 + 2 + 3 + 2 + 2) / 7 = 3.

			Example 3:
				Input: rolls = [1,2,3,4], mean = 6, n = 4
				Output: []
				Explanation: It is impossible for the mean to be 6 no matter what the 4 missing rolls are.
		 */
		#endregion
		public override void Init()
		{
			int[] rolls = { 3, 2, 4, 3 };
			var ans = MissingRolls(rolls, 4, 2);
		}

		public int[] MissingRolls(int[] rolls, int mean, int n)
		{
			int sum = ((mean * (n + rolls.Length)) - rolls.Sum());
			float fDevide = (float)(sum / (float)n);			

			if (fDevide < 1.0f || fDevide > 6f)
				return new int[0];

			int iDevide = (int)fDevide;
			int iPlusCnt = sum - (iDevide * n);
			var result = Enumerable.Range(0, n).Select(_ => iPlusCnt-- > 0 ? iDevide + 1 : iDevide).ToArray();
			return result;
		}
	}
}
