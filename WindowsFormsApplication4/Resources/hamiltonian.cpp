#include <bits/stdc++.h>
#define INF 1e8
#define b(x) (1<<(x))
using namespace std;
int n,m,cost[18][18];
int dp[1<<18][18];
int sol=INF;
 
void init()
{
    for (auto& a: dp) fill(begin(a), end(a), INF);
    dp[1][0]=0;
 
}
 
void read_data()
{
    int x,y,c;
    freopen("hamilton.in", "r", stdin);
    cin>>n>>m;
    for(int i=1;i<=m;i++)
    {
        cin>>x>>y>>c;
        cost[x][y]=c;
    }
}
 
void solve()
{
        for(int mask=3;mask<b(n);mask += 2)
            for(int i=1;i<n;i++)
                for(int j=0;j<n;j++)
                    if(mask & b(j))
                        if(cost[j][i])
                            dp[mask][i] = min(dp[mask][i],dp[mask^b(i)][j]+cost[j][i]);
 
        for(int i=1;i<n;i++)
            if(cost[i][0]!=0)
                sol=min(sol,dp[b(n)-1][i]+cost[i][0]);
 
}
 
void write_result()
{
    freopen("hamilton.out", "w", stdout);
        if(sol==INF) cout<<"Nu exista solutie";
        else         cout<<sol;
}
 
int main()
{
    init();
    read_data();
    solve();
    write_result();
}