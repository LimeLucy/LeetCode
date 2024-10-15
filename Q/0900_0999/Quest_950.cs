using System;

namespace LeetCode.Q
{
	#region ����
	/*
	 * ���� �迭 ���� �־����ϴ�. ��� ī�尡 ������ ������ ���� ī�� ���� �ֽ��ϴ�. 
	 * ith ī���� ������ deck[i]�Դϴ�. ���ϴ� ������� ���� ������ �� �ֽ��ϴ�. 
	 * ó������ ��� ī�尡 �� ���� �������� �ִ� ���·� �����մϴ�. 
	 * ��� ī�尡 ������ ������ ���� �ܰ踦 �ݺ��մϴ�: ���� �� �� ī�带 ������ �����ϰ� ������ �����ϴ�. 
	 * ���� ������ ī�尡 ������ ���� ���� �� �� ī�带 ���� �� �Ʒ��� �����ϴ�. 
	 * ������ �������� ���� ī�尡 ������ 1�ܰ�� ���ư��ϴ�. �׷��� ������ �ߴ��մϴ�. 
	 * ���� ������� ī�带 ���ʴ�� �巯���� ������ ��ȯ�մϴ�. 
	 * ���� ù ��° �׸��� ���� �� ���� �ִ� ������ �����մϴ�.
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
