using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace LeetCode.Q
{
	internal class Quest_2610 : Quest
	{
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