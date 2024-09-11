
using System.Collections.Generic;

namespace LeetCode.Q
{
	internal class Quest_1514 : Quest
	{
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
