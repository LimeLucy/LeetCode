using System;

namespace LeetCode.Q
{
	internal class Quest_042 : Quest
	{
		#region 문제
		/*
		 * 각 막대의 너비가 1인 고도 지도를 나타내는 음수가 아닌 정수 n이 주어질 때, 비가 온 후 얼마나 많은 물을 가둘 수 있는지 계산합니다.
		 * https://assets.leetcode.com/uploads/2018/10/22/rainwatertrap.png
		 * Example 1:
		 *	Input: height = [0,1,0,2,1,0,1,3,2,1,2,1]
			Output: 6
		 * Example 2:
			Input: height = [4,2,0,3,2,5]
			Output: 9
		*/
		#endregion

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
