#include <bits/stdc++.h> 
using namespace std;
 
int n,m;
int visited[100001];
int ST[100001],k=0;
vector <int> G[100001];
vector <int> G_reversed[100001];
 
int components_number=0;
vector<int> components[100001];
void read_data()
{
    int x,y;
    ifstream f("ctc.in");
    f>>n>>m;
    for(int i=1;i<=m;i++)
    {
        f>>x>>y;
        G[x].push_back(y);
        G_reversed[y].push_back(x);
    }
    f.close();
 
}
 
void DFS(int node)
{
    visited[node]=1;
    for(size_t i=0;i<G[node].size();i++)
            {
                int next_node=G[node][i];
                if(visited[next_node]==0) DFS(next_node);
            }
    ST[++k]=node;
}
 
void DFS2(int node)
{
    visited[node]=0;
    for(size_t i=0;i<G_reversed[node].size();i++)
            {
                int next_node=G_reversed[node][i];
                if(visited[next_node]==1) DFS2(next_node);
            }
    components[components_number].push_back(node);
}
 
void kosaraju()
{
    for(int i=1;i<=n;i++)   if(visited[i]==0)     DFS(i);
    for(int i=k;i>=1; i--)  if(visited[ST[i]]==1) components_number++,DFS2(ST[i]);
}
 
void write_result()
{
    ofstream g("ctc.out");
    g<<components_number<<'\n';
    for(int i=1;i<=components_number;i++)
        {
            for(int j=0;j<components[i].size();j++)    g<<components[i][j]<<' ';
            g<<'\n';
        }
 
 
}
 
int main()
{
    read_data();
    kosaraju();
    write_result();
}