/*
	Problem: https://www.hackerrank.com/challenges/tree-preorder-traversal/problem
	Language : C++
	Tool Version : Visual Studio Community 2017
	Thoughts :
	1. If root node pointer is null then quit and stop execution.
	2. If root node is not null then -
		2.1 print root node data.
		2.2 call preOrder function and pass the pointer to left node of root node.
		2.3 call preOrder function and pass the pointer to right node of root node.

	Time Complexity:  O(n) //all the nodes have to be traversed once.
	Space Complexity: O(n) //In DFS approach space is consumed by stack frames used in recursive function calls.
							 Although the maximum stack frames used will be equal to the height of the tree instead
							 but we can say that it is of order n.
	
*/

/* you only have to complete the function given below.  
Node is defined as  

struct node
{
    int data;
    node* left;
    node* right;
};

*/

void preOrder(node *root) {
	if (root == NULL)
	{
		return;
	}
	printf("%d ", root->data);
	preOrder(root->left);
	preOrder(root->right);

}
