#include <bits/stdc++.h>
#define weight first
#define node second
#define mp make_pair
#define INF 1e8
using namespace std;
 
vector < pair <int,int> > Q;
vector < pair <int,int> > G[50001];
pair <int,int> u;
 
int  viz[50001]={0};
int n, m;
int d[50001];
 
bool cmp(const pair<int, int>& a, const pair<int, int>& b)
{
    return a.weight > b.weight;
}
 
void init()
{   d[1]=0;
    viz[1]=1;
    for(int i=2;i<=n;i++) d[i]=INF;
}
 
void read_data()
{
    int x,y,c;
    freopen("dijkstra.in", "r", stdin);
    cin>>n>>m;
    for(int i=1;i<=m;i++)
    {
        cin>>x>>y>>c;
        G[x].push_back( mp(c,y) );
    }
}
 
void dijkstra()
{
    for(auto it:G[1]) Q.push_back(it),push_heap(Q.begin(), Q.end(), cmp),d[it.node] = it.weight;
 
     while(!Q.empty())
    {
        u=Q[0];
        pop_heap(Q.begin(),Q.end(), cmp);
        Q.pop_back();
        if(viz[u.node] == 0)
            {
                viz[u.node]=1;
                for(auto v :G[u.node])
                {
                    if(viz[v.node]==0 && d[v.node]>d[u.node]+v.weight)
                    {
                        d[v.node]=d[u.node]+v.weight;
                        Q.push_back(mp( d[v.node] , v.node));
                        push_heap(Q.begin(),Q.end(), cmp);
                    }
                }
 
            }
 
    }
}
 
void write_result()
{
    freopen("dijkstra.out", "w", stdout);
    for(int i=2;i<=n;i++)
        if(d[i]==INF) cout<<"0 ";
        else cout<<d[i]<<' ';
 
}
int main()
{
 
    read_data();
    init();
    dijkstra();
    write_result();
}