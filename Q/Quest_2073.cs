namespace LeetCode.Q
{
	internal class Quest_2073 : Quest
	{
		public override void Init()
		{
			//1,11,2,16,3,12,4,20,5,13,6,17,7,14,8,19,9,15,10,18
			int[] tickets = { 1, 17, 2, 11, 3, 16, 4, 12, 5, 6, 13, 7, 17, 8, 14, 9, 10, 15 };
			var ans = TimeRequiredToBuy(tickets, 3);
		}

		public int TimeRequiredToBuy(int[] tickets, int k)
		{
			// 1)
			// return tickets.Select((n, index) => tickets[k] > n ? n : index > k ? tickets[k] - 1 : tickets[k]).Sum();

			// 2)
			int len = tickets.Length;
			int sum = 0;
			for(int i = 0; i < len; i++)
			{
				if(tickets[i] < tickets[k])
					sum += tickets[i];
				else
				{
					sum += i > k ? tickets[k] - 1 : tickets[k];
				}
			}			
			return sum;
		}
	}
}
