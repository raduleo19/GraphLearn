#include<bits/stdc++.h>
using namespace std;
 
FILE *f=fopen("ciclueuler.in","r");
FILE *g=fopen("ciclueuler.out","w");
 
int edge_x[500001];
int edge_y[500001];
int viz[500001]= {0};
 
vector <int> G[100001];
stack <int> ST;
int n,m,x,y,ok=1;
 
void read()
{
    fscanf(f,"%d%d",&n,&m);
    for(int i=1; i<=m; i++)
    {
        fscanf(f,"%d%d",&x,&y);
        edge_x[i]=x;
        edge_y[i]=y;
        G[x].push_back(i);
        G[y].push_back(i);
    }
}
 
void euler()
{
    ST.push(1);
    while(!ST.empty())
    {
        int current_node=ST.top();
        if(G[current_node].size())
        {
            int next_node=G[current_node].back();
            G[current_node].pop_back();
            if(viz[next_node]==0)
            {
                viz[next_node]=1;
                if(edge_x[next_node]==current_node) ST.push(edge_y[next_node]);
                else ST.push(edge_x[next_node]);
            }
        }
        else ST.pop(),fprintf(g,"%d ",current_node);
    }
}
 
void solve()
{
    for(int i=1; i<=n && ok==1; i++)   if(G[i].size()%2!=0)   ok=0;
 
    if(ok)
        euler();
    else
        fprintf(g,"%d ",-1);
}
 
int main ()
{
    read();
    solve();
}