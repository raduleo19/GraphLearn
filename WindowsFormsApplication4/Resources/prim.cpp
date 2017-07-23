#include <bits/stdc++.h>
using namespace std;
ifstream f("apm.in");
ofstream g("apm.out");
 
struct Edge
{
    int x,y,c;
    Edge(int _x = 0,int _y = 0,int _c = 0)
    {
        x = _x;
        y = _y;
        c = _c;
    }
    bool operator ()(Edge a,Edge b)
        {
            return a.c > b.c;
        }
};
 
int N,M,costArb;
int Distance[200001];
bitset<200001> Visited;
priority_queue<Edge,vector<Edge>,Edge> Q;
vector<Edge> G[200001];
vector<Edge> Sol;
 
void read_data()
{
    f>>N>>M;
    for (int i=1; i<=M; ++i)
    {
        int x,y,c;
        f>>x>>y>>c;
        G[x].push_back(Edge(x,y,c));
        G[y].push_back(Edge(y,x,c));
    }
}
 
void init()
{
    Distance[1] = 0;
    for (int i=2; i<=N; ++i) Distance[i] = INT_MAX;
}
 
void APM()
{
    Q.push(Edge(0,1,0));
    while (!Q.empty())
    {
        Edge now = Q.top();
        Q.pop();
 
        int node = now.y;
        if (Distance[node] < now.c)
        {
            continue;
        }
        Visited[node] = true;
        costArb += now.c;
        Sol.push_back(now);
 
        for (auto it:G[node])
        {
            int next=it.y;
            int cost=it.c;
            if (Visited[next]==0 && Distance[next] > cost)
            {
                Distance[next] = cost;
                Q.push(Edge(node,next,cost));
            }
        }
    }
}
 
void write_data()
{
    g<<costArb<<"\n"<<Sol.size()-1<<"\n";
    for (int k=1; k < Sol.size(); ++k)
        g<<Sol[k].x<<" "<<Sol[k].y<<"\n";
}
 
int main()
{
    read_data();
    init();
    APM();
    write_data();
}