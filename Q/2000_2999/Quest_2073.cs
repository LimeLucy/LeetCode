namespace LeetCode.Q
{
	internal class Quest_2073 : Quest
	{
		#region 문제
		/*
		 * 표를 사기 위해 줄을 서 있는 사람이 n명이고, 0번째 사람이 줄의 맨 앞에, (n - 1)번째 사람이 줄의 맨 뒤에 있습니다. 
		 * 0번째 사람이 사고자 하는 표의 개수가 티켓[i]인 길이 n의 0 인덱스 정수 배열 티켓이 주어집니다. 
		 * 각 사람이 티켓을 사는 데 정확히 1초가 걸립니다. 한 사람은 한 번에 한 장의 티켓만 구매할 수 있으며, 티켓을 더 구매하려면 줄의 끝으로 돌아가야 합니다(순간적으로 발생). 
		 * 구매할 티켓이 남지 않은 사람은 줄에서 나가게 됩니다. 처음에 위치 k(0 인덱스)에 있는 사람이 티켓 구매를 완료하는 데 걸린 시간을 반환합니다.
		 * 
		 * Example 1:
				Input: tickets = [2,3,2], k = 2
				Output: 6
			Explanation:
				The queue starts as [2,3,2], where the kth person is underlined.
				After the person at the front has bought a ticket, the queue becomes [3,2,1] at 1 second.
				Continuing this process, the queue becomes [2,1,2] at 2 seconds.
				Continuing this process, the queue becomes [1,2,1] at 3 seconds.
				Continuing this process, the queue becomes [2,1] at 4 seconds. Note: the person at the front left the queue.
				Continuing this process, the queue becomes [1,1] at 5 seconds.
				Continuing this process, the queue becomes [1] at 6 seconds. The kth person has bought all their tickets, so return 6.
		 */
		#endregion

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
