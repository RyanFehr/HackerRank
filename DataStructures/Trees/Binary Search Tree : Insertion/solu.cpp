

/*
Node is defined as 

class Node {
    public:
        int data;
        Node *left;
        Node *right;
        Node(int d) {
            data = d;
            left = NULL;
            right = NULL;
        }
};

*/

    Node * insert(Node * root, int data) {
        Node* temp=new Node(data);
        Node* point=root;
        

        if(root==NULL)
        return temp;
        while(true)
        {
            if(point->data>data)
            {if(point->left==NULL)
            {
                point->left=temp;
                break;
            }
            else
            point=point->left;
            }
            else if(point->data<data)
            { if(point->right==NULL)
            {
                point->right=temp;
                break;
            }
            else
            point=point->right;
            }
        }
       


        return root;
    }

