using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Q
{
	internal class Quest_121 : Quest
	{
		/**
		 * 가격 배열이 주어지며, 가격[i]은 째 날의 특정 주식의 가격입니다. 
		 * 한 주식을 매수할 날짜를 선택하고 해당 주식을 매도할 미래의 다른 날짜를 선택하여 수익을 극대화하려고 합니다. 
		 * 이 거래에서 얻을 수 있는 최대 수익을 반환합니다. 수익을 얻을 수 없으면 0을 반환합니다.
		 * 
		 * Example 1:
			Input: prices = [7,1,5,3,6,4]
			Output: 5
			Explanation: Buy on day 2 (price = 1) and sell on day 5 (price = 6), profit = 6-1 = 5.
			Note that buying on day 2 and selling on day 1 is not allowed because you must buy before you sell.

			Example 2:
			Input: prices = [7,6,4,3,1]
			Output: 0
			Explanation: In this case, no transactions are done and the max profit = 0.
		 */
		public int MaxProfit(int[] prices)
		{
			int min = 999999;
			int max = 0;
			int gapM = 0;
			foreach (var n in prices)
			{
				if (n < min)
				{
					min = n;
					max = 0;
				}

				if (n > max)
				{
					max = n;
					gapM = Math.Max(max - min, gapM);
				}
			}
			return gapM;
		}
	}
}
