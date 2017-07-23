#include <bits/stdc++.h>
#define INF 9999999
using namespace std;
ifstream f("bfs.in");
ofstream g("bfs.out");

int N,M,Start;
vector <int> G[100001];
int D[100001]= {0};


int main()
{
    f>>N>>M>>Start;
    for(int i=1; i<=M; i++)
    {
        int x,y;
        f>>x>>y;
        G[x].emplace_back(y);
    }

    for(int i=1; i<=N; i++) D[i]=INF;

    queue <int> Q;
    Q.push(Start);
    D[Start]=0;
    while(!Q.empty())
    {
        int current=Q.front();
        Q.pop();

        for(auto next:G[current])
            if(D[current]+1<D[next])
                {
                    Q.push(next);
                    D[next]=D[current]+1;
                }
    }

    for(int i=1; i<=N; i++) if(D[i]==INF) g<<-1<<' ';
        else  g<<D[i]<<' ';



}
