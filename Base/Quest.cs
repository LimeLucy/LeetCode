﻿using System.Collections.Generic;

namespace LeetCode
{
#region Quest Parent
	class Quest
	{
		public virtual void Init() { }
	}
#endregion

#region Required LeetCode Quest
	public class TreeNode
	{
		public int val;
		public TreeNode? left;
		public TreeNode? right;
		public TreeNode(int val = 0, TreeNode? left = null, TreeNode? right = null)
		{
			this.val = val;
			this.left = left;
			this.right = right;
		}
	}

	public class Node
	{
		public int val;
		public IList<Node>? children = null;

		public Node() { }

		public Node(int _val)
		{
			val = _val;
		}

		public Node(int _val, IList<Node> _children)
		{
			val = _val;
			children = _children;
		}
	}

	public class ListNode
	{
		public int val;
		public ListNode? next;
		public ListNode(int val = 0, ListNode? next = null)
		{
			this.val = val;
			this.next = next;
		}
	}
#endregion
}


