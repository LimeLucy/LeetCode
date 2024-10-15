using System;

namespace LeetCode.Q
{
	internal class Quest_110 : Quest
	{
		#region 문제
		/*
		 * 이진 트리가 주어졌을 때, 높이 균형이 맞는지 판단합니다.
		 * 
		 * 
		 * Example 1:
		 *	https://assets.leetcode.com/uploads/2020/10/06/balance_1.jpg
		 *	Input: root = [3,9,20,null,null,15,7]
			Output: true
		 */
		#endregion

		public override void Init()
		{
			//bool a = IsBalanced(new TreeNode(10, new TreeNode(5, null, new TreeNode(15, null, null)), null));
		}

		public bool IsBalanced(TreeNode root)
		{
			return GetHeight(root) != -1;
		}

		private int GetHeight(TreeNode? current)
		{
			if (current == null) return 0;
			var leftHeight = GetHeight(current.left);
			if (leftHeight == -1) return -1;
			var rightHeight = GetHeight(current.right);
			if (rightHeight == -1) return -1;
			if (Math.Abs(leftHeight - rightHeight) > 1) return -1;
			return Math.Max(leftHeight, rightHeight) + 1;
		}

	}
}
