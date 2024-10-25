using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace LeetCode.Q
{
	/**
	 * 폴더 목록 폴더가 주어지면 해당 폴더의 모든 하위 폴더를 제거한 후 폴더를 반환합니다. 
	 * 어떤 순서로든 답을 반환할 수 있습니다. 
	 * 폴더[i]가 다른 폴더[j] 안에 있는 경우, 이를 폴더의 하위 폴더라고 합니다. 
	 * 폴더[j]의 하위 폴더는 폴더[j]로 시작하고 그 뒤에 "/"가 와야 합니다. 
	 * 예를 들어 "/a/b"는 "/a"의 하위 폴더이지만 "/b"는 "/a/b/c"의 하위 폴더가 아닙니다. 
	 * 경로의 형식은 하나 이상의 연결된 문자열 형식입니다: '/' 뒤에 하나 이상의 영문 소문자가 오는 형식입니다. 
	 * 예를 들어, "/leetcode" 및 "/leetcode/problems"는 유효한 경로이지만 빈 문자열과 "/"는 유효하지 않습니다.
	 */

	/*
	 * 114ms Runtime : Beats 75.00%
	 * 80.52MB Memory : Beats 62.50%
	*/
	internal class Quest_1233 : Quest
	{
		//public override void Init()
		//{			
		//}

		public IList<string> RemoveSubfolders(string[] folder)
		{
			Array.Sort(folder);
			HashSet<string> hashFolder = new HashSet<string>(); // return해야 할 folder list
			int iFolderLen = folder.Length;
			int iNameLen = 0;
			StringBuilder sb = new StringBuilder();
			for(int i = 0; i < iFolderLen; i++)
			{
				sb.Clear();
				iNameLen = folder[i].Length;
				char[] chName = folder[i].ToCharArray();
				for(int j = 0; j < iNameLen; j++)
				{
					sb.Append(chName[j]);
					if(((j < iNameLen - 1 && chName[j + 1] == '/') || (j == iNameLen - 1)))
					{
						if(hashFolder.Contains(sb.ToString()))
							break;
						else
						{
							if(j == iNameLen - 1) // 폴더 이름의 끝까지 봤는데 hash에 없으면 추가
							{
								hashFolder.Add(sb.ToString());
							}
						}
					}
				}
			}
			return hashFolder.ToList();
		}
	}
}
