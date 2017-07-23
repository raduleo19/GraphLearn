#include <bits/stdc++.h>
#define maxN 1002
 
FILE *fin  = freopen("maxflow.in", "r", stdin);
FILE *fout = freopen("maxflow.out", "w", stdout);
 
using namespace std;
int N, M;
int r[maxN][maxN];
int flow;
queue <int> Q;
struct Node{ int dad;vector <int> adj;} G[maxN];
 
void read()
{
    int u, v, capacity;
    scanf("%d %d", &N, &M);
    for(int i = 0; i < M; ++ i)
    {
        scanf("%d %d %d", &u, &v, &capacity);
        G[u].adj.push_back(v);
        G[v].adj.push_back(u);
        r[u][v] = capacity;
    }
 
}
 
bool bfs()
{
    for(int i = 1; i <= N; ++ i)   G[i].dad = 0;
    Q.push(1);
    G[1].dad = 1;
 
    while(!Q.empty())
    {
        int node = Q.front();
        Q.pop();
 
        for(int son : G[node].adj)
        {
            if(r[node][son] == 0 || G[son].dad) continue;
            if(son != N) 
                Q.push(son);
            G[son].dad = node;
        }
    }
    return G[N].dad != 0;
}
 
void solve()
{
    while(bfs())
    {
        for(int node : G[N].adj)
        {
            if(G[node].dad)
            {
                G[N].dad = node;
                int pathFlow = 0x7fffffff;
                node = N;
 
                while(node != 1)
                {
                    pathFlow = min(pathFlow, r[G[node].dad][node]);
                    node = G[node].dad;
                }
                node = N;
 
                while(node != 1)
                {
                    r[G[node].dad][node] -= pathFlow;
                    r[node][G[node].dad] += pathFlow;
                    node = G[node].dad;
                }
                flow += pathFlow;
            }
        }
    }
    printf("%d\n", flow);
}
 
int main()
{
    read();
    solve();
}