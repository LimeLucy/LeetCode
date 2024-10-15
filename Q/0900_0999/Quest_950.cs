using System;

namespace LeetCode.Q
{
	#region 문제
	/*
	 * 정수 배열 덱이 주어집니다. 모든 카드가 고유한 정수를 갖는 카드 덱이 있습니다. 
	 * ith 카드의 정수는 deck[i]입니다. 원하는 순서대로 덱을 정렬할 수 있습니다. 
	 * 처음에는 모든 카드가 한 덱에 뒤집어져 있는 상태로 시작합니다. 
	 * 모든 카드가 공개될 때까지 다음 단계를 반복합니다: 덱의 맨 위 카드를 가져와 공개하고 덱에서 꺼냅니다. 
	 * 덱에 여전히 카드가 있으면 덱의 다음 맨 위 카드를 덱의 맨 아래에 놓습니다. 
	 * 여전히 공개되지 않은 카드가 있으면 1단계로 돌아갑니다. 그렇지 않으면 중단합니다. 
	 * 덱의 순서대로 카드를 차례대로 드러내는 순서를 반환합니다. 
	 * 답의 첫 번째 항목이 덱의 맨 위에 있는 것으로 간주합니다.
	 * 
	 * Example 1:
		Input: deck = [17,13,11,2,3,5,7]
		Output: [2,13,3,11,5,17,7]
		Explanation: 
		We get the deck in the order [17,13,11,2,3,5,7] (this order does not matter), and reorder it.
		After reordering, the deck starts as [2,13,3,11,5,17,7], where 2 is the top of the deck.
		We reveal 2, and move 13 to the bottom.  The deck is now [3,11,5,17,7,13].
		We reveal 3, and move 11 to the bottom.  The deck is now [5,17,7,13,11].
		We reveal 5, and move 17 to the bottom.  The deck is now [7,13,11,17].
		We reveal 7, and move 13 to the bottom.  The deck is now [11,17,13].
		We reveal 11, and move 17 to the bottom.  The deck is now [13,17].
		We reveal 13, and move 17 to the bottom.  The deck is now [17].
		We reveal 17.
		Since all the cards revealed are in increasing order, the answer is correct.

	  Example 2:
		Input: deck = [1,1000]
		Output: [1,1000]
	 */
	#endregion

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
