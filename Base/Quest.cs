﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{	
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

	class Quest
	{
		public virtual void Init() {}
	}
}


