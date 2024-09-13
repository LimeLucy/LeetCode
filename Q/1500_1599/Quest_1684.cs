using System.Collections.Generic;

namespace LeetCode.Q
{
	class Quest_1684 : Quest
	{
		public override void Init()
		{
			string[] words = new string[]{ "cc", "acd", "b", "ba", "bac", "bad", "ac", "d" };
			CountConsistentStrings("cad", words);
		}

		public int CountConsistentStrings(string allowed, string[] words)
		{
			HashSet<char> hashAllowed = new HashSet<char>(allowed);

			int iLen = words.Length;
			int iResult = 0;
			bool isOK = true;
			for(int i = 0; i < iLen; i++)
			{
				isOK = true;
				foreach (var c in words[i])
				{
					if(!hashAllowed.Contains(c))
					{
						isOK = false;
						break;
					}						
				}
				if(isOK)
					iResult++;
			}
			return iResult;
		}
	}
}
