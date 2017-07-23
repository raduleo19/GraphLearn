#include <bits/stdc++.h>
using namespace std;
ifstream f ("apm.in");
ofstream g ("apm.out");
 
int v[200001],n,m,t,a,b,aux,i,cost=0,lg=0,sol[400001],sz[200001];
 
struct edge
{
    int x;
    int y;
    int c;
    bool operator () (edge a,edge b)
    {
        return a.c<b.c;
    }
} T[400001];
 
int main()
{
 
    f>>n>>m;
    for(i=1; i<=m; ++i)
        f>>T[i].x>>T[i].y>>T[i].c;
    sort(T+1,T+1+m,edge());
 
    for(i=1; i<=n; ++i) v[i]=i,sz[i]=1;
 
 
 
    for(i=1; i<=m; i++)
        {
            a=T[i].x;
            while(a!=v[a]) aux=v[v[a]],v[a]=aux,a=aux;
 
            b=T[i].y;
            while(b!=v[b]) aux=v[v[b]],v[b]=aux,b=aux;
 
                if(a!=b)
                {
                    cost+=T[i].c;
                    sol[++lg]=i;
 
                    if(sz[a]<sz[b])
                        v[a]=b,sz[b]+=sz[a];
                    else
                        v[b]=a,sz[a]+=sz[b];
 
                    if(lg>=(n-1))   break;
                }
        }
 
 
    g<<cost<<"\n"<<lg<<"\n";
    for(i=1; i<n; i++)    g<<T[sol[i]].x<<" "<<T[sol[i]].y<<"\n";
 
}