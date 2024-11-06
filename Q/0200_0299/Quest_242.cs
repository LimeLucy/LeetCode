using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Q
{
	internal class Quest_242 : Quest
	{
		/**
		 * 두 문자열 s와 t가 주어졌을 때 t가 s의 아나그램이면 참을 반환하고, 그렇지 않으면 거짓을 반환합니다.
		 * 
		 * Example 1:
			Input: s = "anagram", t = "nagaram"
			Output: true

			Example 2:
			Input: s = "rat", t = "car"
			Output: false
		 */

		public override void Init()
		{
			bool isReturn = IsAnagram("anagram", "nagaram");
		}

		public bool IsAnagram(string s, string t)
		{
			char[] chArrS = s.ToArray();			
			char[] chArrT = t.ToArray();

			Array.Sort(chArrS);
			Array.Sort(chArrT);

			return chArrS.SequenceEqual(chArrT);
		}
	}
}
