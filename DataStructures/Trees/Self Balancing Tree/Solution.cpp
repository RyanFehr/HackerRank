/* Node is defined as :
typedef struct node
{
    int val;
    struct node* left;
    struct node* right;
    int ht;
} node; */
int max(int a,int b)
{
    if(a>=b)
        return a;
    else
        return b;
}
int height(node *root)
{
    if(root==NULL)
        return -1;
    return root->ht;
}
int get_balance(node* root)
{
    return height(root->left)-height(root->right);
}
node* create_node(int key)
{
    node* temp=new node();
    temp->val=key;
    temp->left=temp->right=NULL;
    temp->ht=0;
    return temp;
}
node* right_rotate(node* root)
{
    node* new_root=root->left;
    node* temp=new_root->right;
    new_root->right=root;
    root->left=temp;
    root->ht=max(height(root->left),height(root->right))+1;
    new_root->ht=max(height(new_root->left),height(new_root->right))+1;
    
    return new_root;
}
node* left_rotate(node* root)
{
    node* new_root=root->right;
    node* temp=new_root->left;
    new_root->left=root;
    root->right=temp;
    root->ht=max(height(root->left),height(root->right))+1;
    new_root->ht=max(height(new_root->left),height(new_root->right))+1;
    
    return new_root;
}
node * insert(node * root,int val)
{
	if(root==NULL)
    {
        root=create_node(val);
        return root;
    }
    if(root->val>=val)
    {
        root->left=insert(root->left,val);
    }
    else if(val>root->val)
        root->right=insert(root->right,val);
    
    root->ht=1+max(height(root->right),height(root->left));
    
    int balance=get_balance(root);
    if(balance>1&&val<root->left->val)
    {
       return right_rotate(root);
    }
    else if(balance<-1&&val>root->right->val)
        return left_rotate(root);
    else if(balance>1&&val>root->left->val)
    {
        root->left=left_rotate(root->left);
        return right_rotate(root);
    }
    else if(balance<-1&&val<root->right->val)
    {
        root->right=right_rotate(root->right);
        return left_rotate(root);
    }
    return root;
}


