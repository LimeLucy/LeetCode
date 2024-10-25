using System.Linq;

namespace LeetCode.Q
{
	internal class Quest_670 : Quest
	{
		#region 문제
		/*
		정수가 주어집니다.최대 한 번에 두 자리까지 바꿀 수 있으며 최대값을 얻을 수 있습니다.얻을 수 있는 최대값을 반환합니다.

		Example 1:
			Input: num = 2736
			Output: 7236
			Explanation: Swap the number 2 and the number 7.

		Example 2:
			Input: num = 9973
			Output: 9973
			Explanation: No swap.
		*/

		/*
		 * Runtime 5ms / Beats 100.00%  (Yay!)
		 * Memory 28.40MB / Beats 6.38% (.ㅠㅠ...) 
		 */
		#endregion

		public override void Init()
		{
			int num = MaximumSwap(2736);
		}

		public int MaximumSwap(int num)
		{
			char[] chNums = num.ToString().ToCharArray();
			int iLen = chNums.Length;			

			// 앞에서부터 숫자가 내림차순이 아닌 부분이 있었는지 check
			bool isDescending = true;
			for(int i = 0; i < iLen - 1; i++)
			{
				if(chNums[i] < chNums[i + 1])
				{
					isDescending = false;
					break;
				}
			}
			
			if (!isDescending)
			{
				int iMaxIdx = -1;
				int iMinIdx = -1;
				char chTemp;

				// 높은 값 순서대로 정렬해놓고
				char[] chMaxs = chNums.Distinct().OrderByDescending(n => n).ToArray();
				int iMaxUsed = 0;
				while(true)
				{
					// 높은값이 속해 있는 index를 찾아봐 뒤에서부터..
					for (int i = iLen - 1; i >= 0; i--)
					{
						if(chNums[i] == chMaxs[iMaxUsed])
						{
							iMaxIdx = i;
							break;
						}
					}
				
					// 앞에서부터 높은값보다 작은 수를 찾아서
					for(int i = 0; i <= iMaxIdx; i++)
					{
						if(chNums[i] < chMaxs[iMaxUsed])
						{
							iMinIdx = i;
							break;
						}
					}
				
					// 찾았으면 Swap
					if(iMaxIdx != -1 && iMinIdx != -1)
					{
						chTemp = chNums[iMaxIdx];
						chNums[iMaxIdx] = chNums[iMinIdx];
						chNums[iMinIdx] = chTemp;
						break;
					}

					// 없었으면 다음의 높은수로
					iMaxUsed++;
				}
			}

			return int.Parse(chNums);
		}
	}
}
