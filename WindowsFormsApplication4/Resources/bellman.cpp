#include<bits/stdc++.h>
using namespace std;
ifstream f("bellmanford.in");
ofstream g("bellmanford.out");

queue <int> v;
vector <int> a[50001],c[50001];
int d[50001],w[500001],i,n,m,x,y,z,j;
 
int main()
{
   
    f >> n >> m;
    for (i=1;i<=m;i++)
    {
        f >> x >> y >> z;
        a[x].push_back(y);
        c[x].push_back(z);
    }
    for (i=2;i<=n;i++)   d[i]=1 << 30;
    v.push(1);
    while (!v.empty())
    {
        x=v.front();
        w[x]++;
        if (w[x]>n)
        {
            g << "Ciclu negativ!";
            return 0;
        }
        for (j=0;j<a[x].size();j++)
            if (d[x]+c[x][j]<d[a[x][j]])
            {
                d[a[x][j]]=d[x]+c[x][j];
                v.push(a[x][j]);
            }
        v.pop();
    }
    for (i=2;i<=n;i++)
            g << d[i] << ' ';
}