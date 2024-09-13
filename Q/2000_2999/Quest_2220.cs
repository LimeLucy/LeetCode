using System;

namespace LeetCode.Q
{
	internal class Quest_2220 : Quest
	{
		public override void Init()
		{
			MinBitFlips(10, 82);
		}

		public int MinBitFlips(int start, int goal)
		{
			string strStart = Convert.ToString(start, 2);
			string strGoal = Convert.ToString(goal, 2);

			int iStartLen = strStart.Length;
			int iGoalLen = strGoal.Length;

			if(iStartLen > iGoalLen)
				strGoal = strGoal.PadLeft(iStartLen, '0');
			else if(iStartLen < iGoalLen)
				strStart = strStart.PadLeft(iGoalLen, '0');

			int iLen = strStart.Length;
			int iAnswer = 0;
			for(int i = 0; i < iLen; i++)
			{
				if(strGoal[i] != strStart[i])
					++iAnswer;
			}
			return iAnswer;
		}
	}
}
