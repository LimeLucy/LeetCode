using System;

namespace LeetCode.Q
{
	internal class Quest_110 : Quest
	{
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
