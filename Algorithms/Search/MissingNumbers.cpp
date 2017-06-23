/*
	Problem : https://www.hackerrank.com/challenges/missing-numbers
	C++ 14
	Approach : 
		We start by inputing the arrays a and b. The idea is to find the minimum
		element of both the arrays, and use the indexing with this element. We maintain 
		two frequency arrays, fa and fb that maintain the frequency of each element, i.e.
		fa[i] = frequency of the element i + min(min(a), min(b)).
		Having done that, we print the numbers that had a smaller frequency in a.
		
	Time Complexity : O(n)
	Space Complexity : O( 2*n + constant space for the frequency arrays) 
		          ~ O(n) 
	
	NOTE : The idea of using the indexing with referance to the minimum number is only 
	to avoid making a very large array for frequencies.
*/
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
