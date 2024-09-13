
namespace LeetCode.Q
{
	internal class Quest_2326 : Quest
	{
		//public override void Init()
		//{
		//	//SpiralMatrix(10, 1, new ListNode(8, new ListNode(24, new ListNode(5, new ListNode(21, new ListNode(10, new ListNode(11, new ListNode(11, new ListNode(12, new ListNode(6, new ListNode(17)))))))))));
		//	//SpiralMatrix(1, 4, new ListNode(0, new ListNode(1, new ListNode(2, null))));
		//}

		public enum MoveState
		{
			right = 0,
			down,
			left,
			up,
		};

		public int[][] SpiralMatrix(int m, int n, ListNode? head)
		{
			int[][] result = new int[m][];
			for(int i = 0; i < m; i++)
			{
				result[i] = new int[n];
				for(int j = 0; j < n; j++)
					result[i][j] = -1; // initialize
			}

			int x = 0, y = 0;
			int xMin = 0, xMax = n - 1, yMin = 0, yMax = m - 1;
			MoveState state = MoveState.right;

			while (head != null)
			{
				if(result[y][x] == -1)
				{
					result[y][x] = head.val;
					head = head.next;
				}

				switch (state)
				{
					case MoveState.right :
						x++;
						if(x >= xMax)
						{
							yMin += 1;
							x = xMax;
							state++;							
						}
						break;
					case MoveState.down :
						y++;
						if(y >= yMax)
						{
							xMax -= 1;
							y = yMax;
							state++;							
						}
						break;
					case MoveState.left :
						x--;
						if(x <= xMin)
						{
							yMax -= 1;
							x = xMin;
							state++;
						}
						break;
					case MoveState.up :
						y--;
						if(y <= yMin)
						{
							xMin += 1;
							y = yMin;
							state = MoveState.right;
						}
						break;
				}				
			}
			
			return result;
		}
	}
}
