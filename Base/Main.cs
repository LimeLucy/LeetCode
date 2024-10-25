using LeetCode.Q;

namespace LeetCode
{
	class MainClass
	{
		static Quest? s_Instance = null;

		static void Main(string[] args)
		{
			s_Instance = new Quest_1233(); // TODO : 문제 교체시 문제 번호 교체

			if (s_Instance != null)
			{
				s_Instance.Init();
			}
		}
	}
}
