using System.Linq;

namespace LeetCode.Q
{
	internal class Quest_2028 : Quest
	{
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
