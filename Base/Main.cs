using System;
using System.Collections.Generic;

namespace LeetCode
{
	class MainClass
	{
		static Quest s_Instance = null;

		static void Main(string[] args)
		{
			s_Instance = new Quest_2610();

			if (s_Instance != null)
			{
				s_Instance.Init();
			}
		}
	}
}
