/*
	Problem: https://www.hackerrank.com/challenges/self-balancing-tree/problem
	Language : C++
	Tool Version : Visual Studio Community 2017
	Thoughts :
	1. Insert the new value in the tree like it is done in a Binary Search Tree.
		1.1 If it is first node in the tree then insert it as root node.
		1.2 For all subsequent inserts, insert it in left subtree if value is less than root node data
			and insert it in right subtree if value is more than root node data.
	2. Check the balance factor of all the nodes of the tree starting from the inserted node towards
		root node.
	3. If any unbalanced node is found then detect the imbalance case as one of four categories:
		3.1 Left-Left case : To counter such an imbalance, perform one right rotation at the first node where imbalance is found starting from newly inserted node towards root.
		3.2 Right-Right case : To counter such an imbalance, perform one left rotation at the first node where imbalance is found starting from newly inserted node towards root.
		3.3 Left-Right case : To counter such an imbalance: 
							  -	perform one left rotation at the node which is next to the first node where imbalance is found 
								(This is the first node encountered when you start traversing towards newly inserted from the imbalanced node).
							  -	perform one right rotation at node where first imbalance was found.
		3.4 Right-Left case : To counter such an imbalance: 
							  -	perform one right rotation at the node which is next to the first node where imbalance is found 
								(This is the first node encountered when you start traversing towards newly inserted from the imbalanced node).
							  -	perform one left rotation at node where first imbalance was found.



	Time Complexity:  O(log(n)) //time complexity of a general Binary Search Tree is O (n) in left/right skewed trees.
								Since AVL trees are height balanced so it turns out to be of order of log(n).
	Space Complexity: O(n) //recursive calls to insert method requires n stack frames.

*/

/* Node is defined as :
typedef struct node
{
    int val;
    struct node* left;
    struct node* right;
    int ht;
} node; */

node* newAvlTreeNode(int data);
int heightOfSubtree(node *nod);
int maxVal(int a, int b);
node *leftRotate(node *x);
node* rightRotate(node *y);
int getBalance(node *Nod);

node* insert(node* root,int val)
{
	if (root == NULL)
		return  newAvlTreeNode(val);

	if (val < root -> val)
		root->left = insert(root->left,val );
	else if (val > root->val)
		root->right = insert(root->right,val );


	root->ht = 1 + maxVal(heightOfSubtree(root->left), heightOfSubtree(root->right));

	//Get the balance factor of parent node
	int balance = getBalance(root);

	if (balance > 1 && val < root->left->val)
		return rightRotate(root);

	// Right Right Case
	if (balance < -1 && val > root->right->val)
		return leftRotate(root);

	// Left Right Case
	if (balance > 1 && val > root->left->val)
	{
		root->left = leftRotate(root->left);
		return rightRotate(root);
	}

	// Right Left Case
	if (balance < -1 && val < root->right->val)
	{
		root->right = rightRotate(root->right);
		return leftRotate(root);
	}
	return root;
}

node* rightRotate(node *y)
{
	node* x = y->left;
	node* T2 = x->right;

	// Perform rotation
	x->right = y;
	y->left = T2;

	// Update heights
	y->ht = maxVal(heightOfSubtree(y->left), heightOfSubtree(y->right)) + 1;
	x->ht = maxVal(heightOfSubtree(x->left), heightOfSubtree(x->right)) + 1;

	// Return new root
	return x;
}


node *leftRotate(node *x)
{
	node *y = x->right;
	node *T2 = y->left;

	// Perform rotation
	y->left = x;
	x->right = T2;

	//  Update heights
	x->ht = maxVal(heightOfSubtree(x->left), heightOfSubtree(x->right)) + 1;
	y->ht = maxVal(heightOfSubtree(y->left), heightOfSubtree(y->right)) + 1;

	// Return new root
	return y;
}

int getBalance(node *Nod)
{
	if (Nod == NULL)
		return 0;
	return heightOfSubtree(Nod->left) - heightOfSubtree(Nod->right);
}

int maxVal(int a,int b)
{
	return (a > b) ? a : b;
}

node* newAvlTreeNode(int data)
{
	// Allocate memory for new node 
	node* treeNode = (node*)malloc(sizeof(node));

	// Assign data to this node
	treeNode->val = data;

	// Initialize left and right children as NULL
	treeNode->left = NULL;
	treeNode->right = NULL;
	treeNode->ht = 0;
	return(treeNode);
}

int heightOfSubtree(node *nod)
{
	if (nod == NULL)
		return -1;
	return nod->ht;
}
