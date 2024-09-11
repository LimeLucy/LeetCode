using LeetCode.Q;

namespace LeetCode
{
	class MainClass
	{
		static Quest? s_Instance = null;

		static void Main(string[] args)
		{
			s_Instance = new Quest_15();

			if (s_Instance != null)
			{
				s_Instance.Init();
			}
		}
	}
}
