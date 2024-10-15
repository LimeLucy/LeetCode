using System;

namespace LeetCode.Q
{
	internal class Quest_2220 : Quest
	{
		#region 문제
		/*
		 * 숫자 x의 비트 플립은 x의 이진 표현에서 비트를 선택하여 0에서 1 또는 1에서 0으로 뒤집는 것입니다. 
		 * 예를 들어, x = 7의 경우 이진 표현은 111이며 표시되지 않은 선행 0을 포함하여 임의의 비트를 선택하여 플립할 수 있습니다. 
		 * 오른쪽에서 첫 번째 비트를 뒤집어 110을 얻고, 오른쪽에서 두 번째 비트를 뒤집어 101을 얻고, 오른쪽에서 다섯 번째 비트(선행 0)를 뒤집어 10111 등을 얻을 수 있습니다. 
		 * 두 정수의 시작과 끝이 주어지면 시작과 끝을 변환하기 위한 최소 비트 뒤집기 횟수를 반환합니다.
		 * 
		 * Example 1:
			Input: start = 10, goal = 7
			Output: 3
			Explanation: The binary representation of 10 and 7 are 1010 and 0111 respectively. We can convert 10 to 7 in 3 steps:
			- Flip the first bit from the right: 1010 -> 1011.
			- Flip the third bit from the right: 1011 -> 1111.
			- Flip the fourth bit from the right: 1111 -> 0111.
			It can be shown we cannot convert 10 to 7 in less than 3 steps. Hence, we return 3.

		   Example 2:
			Input: start = 3, goal = 4
			Output: 3
			Explanation: The binary representation of 3 and 4 are 011 and 100 respectively. We can convert 3 to 4 in 3 steps:
			- Flip the first bit from the right: 011 -> 010.
			- Flip the second bit from the right: 010 -> 000.
			- Flip the third bit from the right: 000 -> 100.
			It can be shown we cannot convert 3 to 4 in less than 3 steps. Hence, we return 3.
		 */
		#endregion

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
