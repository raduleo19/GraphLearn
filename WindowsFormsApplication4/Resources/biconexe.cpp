#include <bits/stdc++.h>
using namespace std;
vector<int> G[100000],RS[100000];
int N,M,T[100000],P[100000],rs,St[100000],st;
ifstream f("biconex.in");
ofstream g("biconex.out");
 
void DFS(int node)
{
    St[++st] = node;
 
    for(auto next:G[node])
        if(P[next]) P[node] = min(P[node],T[next]);
        else
        {
            int p=st;
            P[next] = T[next] = T[node] + 1;
            DFS(next);
            P[node] = min(P[node],P[next]);
            if(P[next] >= T[node])
            {
                RS[++rs].push_back(node);
                while(p<st) RS[rs].push_back(St[st--]);
            }
        }
}
 
int main()
{
 
    f>>N>>M;
    for(int x,y; M--;)
    {
        f>>x>>y;
        G[x].push_back(y);
        G[y].push_back(x);
    }
    T[1]=P[1] = 1;
    DFS(1);
    g<< rs << '\n';
    while(rs)
    {
        for(auto it:RS[rs])
            g<<it<<' ';
        g<<'\n';
        rs--;
    }
}