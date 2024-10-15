using System;
using System.Collections.Generic;

namespace LeetCode.Q
{
	internal class Quest_015 : Quest
	{
		#region 문제
		/*
		 * 정수 배열 nums가 주어졌을 때, i != j, i != k, j != k, nums[i] + nums[j] + nums[k] == 0이 되는 모든 삼중항을 반환합니다. 
		 * 솔루션 집합에는 중복된 삼중항이 없어야 한다는 점에 유의하세요.
		 * 
		 Example 1:
			Input: nums = [-1,0,1,2,-1,-4]
			Output: [[-1,-1,2],[-1,0,1]]

		Example 2:
			Input: nums = [0,1,1]
			Output: []

		Example 3:
			Input: nums = [0,0,0]
			Output: [[0,0,0]]
		 */
		#endregion

		public override void Init()
		{
			int[] nums = new int[]{ 0, 0, 0 };	// 예제 1
			//int[] nums = new int[]{-1, -1, 0, 1, 2, -4 };	// 예제 2
			var ans = ThreeSum(nums);
		}

		public IList<IList<int>> ThreeSum(int[] nums)
		{			
			Array.Sort(nums);
			int len = nums.Length;

			// two pointer
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
