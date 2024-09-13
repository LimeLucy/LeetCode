using System;
using System.Collections.Generic;

namespace LeetCode.Q
{
	internal class Quest_15 : Quest
	{
		public override void Init()
		{
			int[] nums = new int[]{ 0, 0, 0 };
			//int[] nums = new int[]{-1, -1, 0, 1, 2, -4 };
			var ans = ThreeSum(nums);
		}

		public IList<IList<int>> ThreeSum(int[] nums)
		{
			Array.Sort(nums);
			int len = nums.Length;

			int left = 0, bef_left = 0;
			int right = 0, bef_right = 0;
			int sum = 0;
			IList<IList<int>> result = new List<IList<int>>();

			for (int i = 0; i < len - 1; i++)
			{
				if(i > 0 && nums[i] == nums[i - 1])
					continue;

				left = i + 1;
				right = len - 1;
				while (left < right)
				{
					sum = nums[left] + nums[i] + nums[right];

					if(sum < 0)
						left++;
					else if(sum > 0)
						right--;
					else
					{
						List<int> list = new List<int>();
						list.Add(nums[left]);
						list.Add(nums[i]);
						list.Add(nums[right]);
						result.Add(list);

						bef_left = nums[left];
						bef_right = nums[right];

						while (left < right&& nums[left] == bef_left)
							left++;

						while(left < right && nums[right] == bef_right)
							right--;
					}
				}
			}

			return result;
		}
	}
}
