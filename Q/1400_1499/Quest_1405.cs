using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Q
{
	internal class Quest_1405 : Quest
	{
		#region 문제
		/*
		 * s는 다음 조건을 만족하는 문자열을 행복이라고 합니다: 
		 * s는 문자 'a', 'b', 'c'만 포함합니다.s는 부분 문자열로 'aaa', 'bbb', 'ccc'를 포함하지 않습니다.
		 * s는 문자 'a'가 최대 한 번까지 포함됩니다.
		 * s는 문자 'b'가 최대 두 번까지 포함됩니다.
		 * s는 문자 'c'가 최대 세 번까지 포함됩니다.
		 * 정수 a, b, c가 주어지면 가능한 가장 긴 행복 문자열을 반환합니다. 
		 * 가장 긴 문자열이 여러 개 있으면 그 중 하나를 반환합니다. 그러한 문자열이 없으면 빈 문자열 ""을 반환합니다. 
		 * 하위 문자열은 문자열 내의 연속적인 문자 시퀀스입니다.
		 * 
		 * Example 1:
			Input: a = 1, b = 1, c = 7
			Output: "ccaccbcc"
			Explanation: "ccbccacc" would also be a correct answer.

		   Example 2:
			Input: a = 7, b = 1, c = 0
			Output: "aabaa"
			Explanation: It is the only correct answer in this case.
		 */
		#endregion

		public override void Init()
		{
			string strAns = LongestDiverseString(0, 8, 11);
		}

		// 가장 긴 word는 2개씩 출력, 그 다음으로 긴 word는 seg로 사용하여 1개씩 출력 //
		public string LongestDiverseString(int a, int b, int c)
		{
			StringBuilder sb = new StringBuilder();

			int iAddType = -1;	// 처음 init type : none 상태
			int[] iArrCnt = new int[3];
			string[] strArrChar = new string[]{"a", "b", "c" };
			iArrCnt[0] = a; iArrCnt[1] = b; iArrCnt[2] = c; // 갯수를 배열에 셋팅

			int iCurType = 0;
			int iSegType = 0;
			int iSegCnt = 0;
			int[] iComp = new int[2];
			
			while(iArrCnt.Any(n => n > 0)) // 하나라도 0보다 크면
			{
				if(iAddType == -1)
				{
					iCurType = iArrCnt[0] > iArrCnt[1] ? 0 : 1;
					iCurType = iArrCnt[iCurType] > iArrCnt[2] ? iCurType : 2;
					iSegCnt = iArrCnt[iCurType] / 2;
					iSegType = iCurType;
				}
				else
				{
					for(int i = 0, j = 0; i < 3; i++)
					{
						if(i != iAddType)
							iComp[j++] = i;
					}

					if (iArrCnt[iComp[0]] == 0 && iArrCnt[iComp[1]] == 0)   // 남은거 두개가 모두 0이면 break
						break;

					iCurType = iArrCnt[iComp[0]] > iArrCnt[iComp[1]] ? iComp[0] : iComp[1];

					if (iArrCnt[iAddType] < iArrCnt[iCurType]) // 이전에 add된 타입보다 현재 타입의 갯수가 더 크면 seg 변경
					{
						iSegCnt = iArrCnt[iCurType] / 2;
						iSegType = iCurType;
					}
				}

				if(iArrCnt[iCurType] == 0) // 이번에 처리해야 하는 타입이 값이 0이면.. 문자열을 더 생성 불가능
					break;

				if(iArrCnt[iCurType] < 2 || (iCurType != iSegType && iSegCnt > 0))
				{
					sb.Append(strArrChar[iCurType]);
					iArrCnt[iCurType] -= 1;
				}
				else
				{
					sb.Append(strArrChar[iCurType] + strArrChar[iCurType]);
					iArrCnt[iCurType] -= 2;
				}
				iAddType = iCurType;
			}
			return sb.ToString();
		}
	}
}
