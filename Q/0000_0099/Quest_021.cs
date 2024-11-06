using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Q
{
	internal class Quest_021 : Quest
	{
		/**
		 * 두 개의 정렬된 링크된 목록 목록1과 목록2의 헤드가 주어집니다. 두 목록을 하나의 정렬된 목록으로 병합합니다. 
		 * 이 목록은 처음 두 목록의 노드를 연결하여 만들어야 합니다. 병합된 링크된 목록의 헤드를 반환합니다.
		 * 
		 * https://assets.leetcode.com/uploads/2020/10/03/merge_ex1.jpg
		 * Example 1:
		 * Input: list1 = [1,2,4], list2 = [1,3,4]
			Output: [1,1,2,3,4,4]

			Example 2:
			Input: list1 = [], list2 = []
			Output: []

			Example 3:
			Input: list1 = [], list2 = [0]
			Output: [0]
		 */
		public ListNode MergeTwoLists(ListNode l1, ListNode l2)
		{
			if (l1 == null && l2 == null)
				return null;

			if (l1 == null)
				return l2;

			if (l2 == null)
				return l1;

			if (l1.val <= l2.val)
			{
				l1.next = MergeTwoLists(l1.next, l2);
				return l1;
			}
			else
			{
				l2.next = MergeTwoLists(l1, l2.next);
				return l2;
			}
		}
	}
}
