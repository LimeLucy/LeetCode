
namespace LeetCode.Q
{
	internal class Quest_2326 : Quest
	{
		#region 문제
		/*
		 * 행렬의 차원을 나타내는 두 개의 정수 m과 n이 주어집니다. 
		 * 또한 연결된 정수 목록의 머리도 주어집니다. 
		 * 행렬의 왼쪽 위부터 시계 방향으로 나선형 순서로 표시된 연결된 목록의 정수를 포함하는 m x n 행렬을 생성합니다. 
		 * 빈 공간이 남으면 -1로 채웁니다. 생성된 행렬을 반환합니다.
		 * 
		 * Example 1:
			https://assets.leetcode.com/uploads/2022/05/09/ex1new.jpg
			Input: m = 3, n = 5, head = [3,0,2,6,8,1,7,9,4,2,5,5,0]
			Output: [[3,0,2,6,8],[5,0,-1,-1,1],[5,2,4,9,7]]
			Explanation: The diagram above shows how the values are printed in the matrix.
			Note that the remaining spaces in the matrix are filled with -1.
		 */
		#endregion

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
