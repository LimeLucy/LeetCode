using System;

namespace LeetCode.Q
{
	internal class Quest_950 : Quest
	{
		public override void Init()
		{
			int[] deck = {17, 13, 11, 2, 3, 5, 7 };
			var ans = DeckRevealedIncreasing(deck);
		}
		public int[] DeckRevealedIncreasing(int[] deck)
		{
			Array.Sort(deck);
			int len = deck.Length;
			int[] result = new int[len];

			int idx = 0;
			int iStop = 2;
			int iCnt = 0;
			while(iCnt < len)
			{
				if(iStop == 2)
				{
					result[idx] = deck[iCnt++];
					iStop = 0;
				}

				idx = (idx + 1) % len;
				if(result[idx] == 0)
					++iStop;
			}
			return result;
		}
	}
}
