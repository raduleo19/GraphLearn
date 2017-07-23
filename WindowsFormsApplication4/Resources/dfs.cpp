#include <bits/stdc++.h>
#define INF 9999999
using namespace std;
ifstream f("bfs.in");
ofstream g("bfs.out");

int N,M,Start;
vector <int> G[100001];
int Viz[100001]= {0};

void DFS(int node)
{
	Viz[node]=1;
	for(auto next:G[node])
		if(Viz[next]==0) DFS(next);	
}

int main()
{
    f>>N>>M>>Start;
    for(int i=1; i<=M; i++)
    {
        int x,y;
        f>>x>>y;
        G[x].emplace_back(y);
    }	
	DFS(Start);
}
