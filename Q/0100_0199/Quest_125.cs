using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Q._0100_0199
{
	internal class Quest_125
	{
		/**
		 * 구문은 모든 대문자를 소문자로 변환하고 영숫자가 아닌 문자를 모두 제거한 후 앞뒤로 같은 문자를 읽으면 팔린드롬입니다. 
		 * 영숫자 문자는 문자와 숫자를 포함합니다. 
		 * 문자열 s가 주어지면 팔린드롬인 경우 참을 반환하고, 그렇지 않으면 거짓을 반환합니다.
		 * 
		 * Example 1:
			Input: s = "A man, a plan, a canal: Panama"
			Output: true
			Explanation: "amanaplanacanalpanama" is a palindrome.

			Example 2:
			Input: s = "race a car"
			Output: false
			Explanation: "raceacar" is not a palindrome.

			Example 3:
			Input: s = " "
			Output: true
			Explanation: s is an empty string "" after removing non-alphanumeric characters.
			Since an empty string reads the same forward and backward, it is a palindrome.
		 */

		public bool IsPalindrome(string s)
		{
			var cStr = s.ToLower().Where(c => Char.IsLetterOrDigit(c)).Select(c => c).ToArray();
			int sLen = cStr.Length;
			if (sLen <= 1)
				return true;
			int HalfLen = sLen >> 1;
			for (int i = 0; i < HalfLen; i++)
			{
				if (cStr[i] != cStr[^(i + 1)])
					return false;
			}
			return true;
		}
	}
}
