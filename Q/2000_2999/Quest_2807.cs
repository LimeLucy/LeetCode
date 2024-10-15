
namespace LeetCode.Q
{
	internal class Quest_2807 : Quest
	{
		#region 문제
		/*
		 * 각 노드에 정수 값이 포함된 연결된 목록의 헤드가 주어집니다. 
		 * 인접한 모든 노드 쌍 사이에 그 노드의 최대공약수와 같은 값을 가진 새 노드를 삽입합니다. 
		 * 삽입 후 연결된 목록을 반환합니다. 
		 * 두 숫자의 최대공약수는 두 숫자를 균등하게 나누는 가장 큰 양의 정수입니다.
		 * 
		 * Example 1:
			https://assets.leetcode.com/uploads/2023/07/18/ex1_copy.png
			Input: head = [18,6,10,3]
			Output: [18,6,6,2,10,1,3]
			Explanation: The 1st diagram denotes the initial linked list and the 2nd diagram denotes the linked list after inserting the new nodes (nodes in blue are the inserted nodes).
			- We insert the greatest common divisor of 18 and 6 = 6 between the 1st and the 2nd nodes.
			- We insert the greatest common divisor of 6 and 10 = 2 between the 2nd and the 3rd nodes.
			- We insert the greatest common divisor of 10 and 3 = 1 between the 3rd and the 4th nodes.
			There are no more adjacent nodes, so we return the linked list.
		 */
		#endregion


		//public override void Init()
		//{			
		//}

		public ListNode? InsertGreatestCommonDivisors(ListNode? head)
		{
			ListNode? result = head;

			while(head != null && head.next != null)
			{
				head.next = new ListNode(GCD(head.val, head.next.val), head.next);
				head = head.next.next;
			}
			return result;
		}

		int GCD(int x, int y)
		{
			return y == 0 ? x : GCD(y, x % y);
		}
	}
}
