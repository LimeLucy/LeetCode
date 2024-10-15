using System.Collections.Generic;

namespace LeetCode.Q
{
	class Quest_1684 : Quest
	{
		#region 문제
		/*
		고유 문자로 구성된 허용된 문자열과 문자열 단어의 배열이 주어집니다.
		문자열의 모든 문자가 허용된 문자열에 나타나면 문자열은 일관된 문자열입니다.
		배열 단어에서 일관된 문자열의 수를 반환합니다.

		Example 1:
			Input: allowed = "ab", words = ["ad","bd","aaab","baa","badab"]
			Output: 2
			Explanation: Strings "aaab" and "baa" are consistent since they only contain characters 'a' and 'b'.
		Example 2:
			Input: allowed = "abc", words = ["a","b","c","ab","ac","bc","abc"]
			Output: 7
			Explanation: All strings are consistent.
		Example 3:
			Input: allowed = "cad", words = ["cc","acd","b","ba","bac","bad","ac","d"]
			Output: 4
			Explanation: Strings "cc", "acd", "ac", and "d" are consistent.
		*/
		#endregion
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
