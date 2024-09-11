using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Q
{
	internal class Quest_2807 : Quest
	{
		public override void Init()
		{			
		}

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
