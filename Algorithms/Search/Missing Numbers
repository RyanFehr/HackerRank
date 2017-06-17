#include <iostream>
#include <string>
using namespace std;

int main(){
	int fa[202], fb[202], i=0;
	int n, m;
	cin>>n;
	int a[n], amin=10000;
	for(i=0; i<n; i++){
		cin>>a[i];
		if(a[i]<=amin){
			amin= a[i];
		}
	}
	cin>>m;
	int b[m], bmin=10000;
	for(i=0; i<m; i++){
		cin>>b[i];
		if(b[i]<bmin){
			bmin= b[i];
		}
	}
	for(i=0; i<202; i++){
		fa[i]=0; fb[i]=0;
	}
	int center= (amin<bmin)?amin:bmin;
	for(i=0; i<n; i++){
		fa[a[i]-center]++;
	}
	for(i=0; i<m; i++){
		fb[b[i]-center]++;
	}
	for(i=0; i<202; i++){
		if(fb[i]>fa[i]){
			cout<<(i+center)<<" ";
		}
	}
	return 0;
}
