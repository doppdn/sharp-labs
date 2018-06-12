using System;
using System.Collections.Generic;

namespace lab1
{
// Number of vertices in given graph

    class FordFulkerson
    {
        private int V;

        public FordFulkerson(int v)
        {
            V = v;
        }

        public bool bfs(int[,] rGraph, int s, int t, int[] parent)
        {
            bool[] visited = new bool[V];
        
            Queue<int> q = new Queue<int>();            
            q.Enqueue(s);
            visited[s] = true;
            parent[s] = -1;
        
            while (q.Count != 0)
            {
                int u = q.Peek();
                q.Dequeue();
        
                for (int v=0; v<V; v++)
                {
                    if (visited[v]==false && rGraph[u,v] > 0)
                    {
                        q.Enqueue(v);
                        parent[v] = u;
                        visited[v] = true;
                    }
                }
            }

            return (visited[t] == true);
        }
        

        public int fordFulkerson(int[,] graph, int s, int t)
        {
            int u, v;
            int[,] rGraph = new int[V, V]; 

            for (u = 0; u < V; u++)
                for (v = 0; v < V; v++)
                    rGraph[u, v] = graph[u,v];
        
            int[] parent = new int[V];  
            int max_flow = 0; 
    
            while (bfs(rGraph, s, t, parent))
            {
                int path_flow = Int32.MaxValue;
                for (v=t; v!=s; v=parent[v])
                {
                    u = parent[v];
                    path_flow = System.Math.Min(path_flow, rGraph[u,v]);
                }
        
                for (v=t; v != s; v=parent[v])
                {
                    u = parent[v];
                    rGraph[u,v] -= path_flow;
                    rGraph[v,u] += path_flow;
                }

                max_flow += path_flow;
            }
        
            return max_flow;
        }
    }
}