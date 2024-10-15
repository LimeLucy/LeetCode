using System;

namespace LeetCode.Q
{
	internal class Quest_111 : Quest
	{
		#region 문제
		/*
		 * 이진 트리가 주어졌을 때, 그 최소 깊이를 구합니다. 최소 깊이는 루트 노드에서 가장 가까운 리프 노드까지 최단 경로를 따라 내려가는 노드의 수입니다. 
		 * 참고: 리프는 자식이 없는 노드입니다.
		 * Example 1:
			https://assets.leetcode.com/uploads/2020/10/12/ex_depth.jpg
			Input: root = [3,9,20,null,null,15,7]
			Output: 2
		 */
		#endregion

		public int MinDepth(TreeNode? root)
		{
			if (root == null) return 0;
			if (root.left == null) return MinDepth(root.right) + 1;
			if (root.right == null) return MinDepth(root.left) + 1;
			return Math.Min(MinDepth(root.left), MinDepth(root.right)) + 1;
		}
	}
}
