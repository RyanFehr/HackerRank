
  
/* 
The structure of the node is

typedef struct node {

	int freq;
    char data;
    node * left;
    node * right;
    
} node;

*/


void decode_huff(node * root, string s) {
    node* temp=root;
    int i=0,j=0;
    char s1[25];
    while(s[i]!='\0')
    {
        if(s[i]=='1')
            root=root->right;
        else//equal to 0
            root=root->left;
        if(root->right==NULL)
            {
                s1[j]=root->data;
                printf("%c",s1[j]);
                j++;
                
                root=temp;
            }
        i++;
    }
}

