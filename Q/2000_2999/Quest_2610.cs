using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace LeetCode.Q
{
	internal class Quest_2610 : Quest
	{
		#region 문제
		/*
		 * 정수 배열 num이 주어집니다. 다음 조건을 만족하는 숫자로 2D 배열을 만들어야 합니다: 
		 * 2D 배열은 배열 숫자의 원소만 포함해야 합니다. 2D 배열의 각 행은 고유한 정수를 포함해야 합니다. 
		 * 2D 배열의 행 수는 최소여야 합니다. 결과 배열을 반환합니다. 
		 * 답이 여러 개 있으면 그 중 하나를 반환합니다. 
		 * 2D 배열은 각 행의 요소 수가 다를 수 있다는 점에 유의하세요.
		 * 
		 * Example 1:
			Input: nums = [1,3,4,1,2,3,1]
			Output: [[1,3,4,2],[1,3],[1]]
			Explanation: We can create a 2D array that contains the following rows:
			- 1,3,4,2
			- 1,3
			- 1
			All elements of nums were used, and each row of the 2D array contains distinct integers, so it is a valid answer.
			It can be shown that we cannot have less than 3 rows in a valid array.

		   Example 2:
			Input: nums = [1,2,3,4]
			Output: [[4,3,2,1]]
			Explanation: All elements of the array are distinct, so we can keep all of them in the first row of the 2D array.
		 */
		#endregion

		public override void Init()
		{
			int[] a = new int[] { 1,3,4,1,2,3,1 };
			var b = FindMatrix(a);
			Console.WriteLine(b);
		}

		public IList<IList<int>> FindMatrix(int[] nums)
		{
			IList<IList<int>> ret = new List<IList<int>>();
			nums = nums.OrderBy(num => num).ToArray();

			int len = nums.Length;
			int iBefNum = -1, iNumCnt = 0;
			for(int i = 0; i < len; i++)
			{
				if(iBefNum != nums[i])
				{
					iBefNum = nums[i];
					iNumCnt = 0;
					if(ret.Count <= iNumCnt)
						ret.Add(new List<int>());
					ret[iNumCnt].Add(nums[i]);
				}
				else
				{
					++iNumCnt;
					if (ret.Count <= iNumCnt)
						ret.Add(new List<int>());
					ret[iNumCnt].Add(nums[i]);
				}
			}

			return ret;
		}
	}
}