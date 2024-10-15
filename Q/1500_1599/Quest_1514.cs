using System.Collections.Generic;

namespace LeetCode.Q
{
	internal class Quest_1514 : Quest
	{
		#region 문제
		/*
		 * 노드 a와 b를 연결하는 방향이 없는 에지 목록으로 표시되는 노드 n개(0-인덱스)의 가중 그래프가 주어지며, 에지[i] = [a, b]는 해당 에지 통과 성공 확률 succProb[i]입니다. 
		 * 두 노드가 시작과 끝이 주어지면 시작에서 끝까지 이동할 수 있는 최대 성공 확률을 가진 경로를 구하고 그 성공률을 반환합니다. 
		 * 시작에서 끝까지의 경로가 없으면 0을 반환합니다. 정답과 최대 1e-5만큼 차이가 나면 정답으로 인정됩니다.
		 * 
		 * Example 1:
			https://assets.leetcode.com/uploads/2019/09/20/1558_ex1.png
		 	Input: n = 3, edges = [[0,1],[1,2],[0,2]], succProb = [0.5,0.5,0.2], start = 0, end = 2
			Output: 0.25000
			Explanation: There are two paths from start to end, one having a probability of success = 0.2 and the other has 0.5 * 0.5 = 0.25.
		 */
		#endregion
		public double MaxProbability(int n, int[][] edges, double[] succProb, int start_node, int end_node)
		{
			PriorityQueue<(int node, double prob), double> pq = new PriorityQueue<(int, double), double>(Comparer<double>.Create((x, y) => y.CompareTo(x)));
			double[] dp = new double[n];

			List<KeyValuePair<int, double>>[] lstEdge = new List<KeyValuePair<int, double>>[n];
			for (int i = 0; i < n; i++)
				lstEdge[i] = new List<KeyValuePair<int, double>>();

			int iEdgeCaseCnt = edges.Length;
			for (int i = 0; i < iEdgeCaseCnt; i++)
			{
				lstEdge[edges[i][0]].Add(new KeyValuePair<int, double>(edges[i][1], succProb[i]));
				lstEdge[edges[i][1]].Add(new KeyValuePair<int, double>(edges[i][0], succProb[i]));
			}

			pq.Enqueue((start_node, 1), 1);
			dp[start_node] = 1;

			int next;
			double nextProb;
			while (pq.Count != 0)
			{
				var (curNode, curProb) = pq.Dequeue();

				if (curNode == end_node)
					return curProb;

				if (curProb < dp[curNode])
					continue;

				foreach (var edge in lstEdge[curNode])
				{
					next = edge.Key;
					nextProb = edge.Value * curProb;

					if (dp[next] < nextProb)
					{
						dp[next] = nextProb;
						pq.Enqueue((next, nextProb), nextProb);
					}
				}
			}
			return 0;
		}
	}
}
