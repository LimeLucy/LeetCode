using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Q
{
	internal class Quest_42 : Quest
	{
		public override void Init()
		{
			int[] height = { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 };
			//int[] height = { 4, 2, 0, 3, 2, 5 };
			var answer = Trap(height);
		}

		public int Trap(int[] height)
		{
			int len = height.Length;
			int max_idx = 0;
			for(int i = 0; i < len; i++)
			{
				if(height[max_idx] < height[i])
					max_idx = i;
			}

			int max = height[0];
			int sum = 0;
			for(int i = 0; i <= max_idx; i++)
			{
				sum += Math.Max(0, max - height[i]);
				max = Math.Max(max, height[i]);
			}

			max = height[len - 1];
			for(int i = len - 1; i >= max_idx; i--)
			{
				sum += Math.Max(0, max - height[i]);
				max = Math.Max(max, height[i]);
			}

			return sum;

		}
	}
}
