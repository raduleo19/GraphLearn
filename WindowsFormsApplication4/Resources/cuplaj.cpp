#include <bits/stdc++.h>
using namespace std;
ifstream f("cuplaj.in");
ofstream g("cuplaj.out");
int n,m,k,MaxMatch=0,R[10000],L[10000];
vector<int> v[10000];
bitset<10000> T;
 
inline int DFS(int n)
{
    if (T[n])return 0;
    T[n]=1;
    for (auto j:v[n]) if (!L[j]) return L[j]=n,R[n]=j;
    for (auto j:v[n]) if (DFS(L[j])) return L[j]=n,R[n]=j;
    return 0;
}
 
int main()
{
    f>>n>>m>>k;
    for (int i=1; i<=k; ++i)
    {
        int x,y;
        f>>x>>y,v[x].push_back(y);
    }
    for(int i=1; i<=n; ++i) if(!R[i]&&DFS(i))++MaxMatch,T=0;
 
    g<<MaxMatch<<'\n';
    for (int i=1; i<=n; ++i) if (R[i])g<<i<<" "<<R[i]<<'\n';
}