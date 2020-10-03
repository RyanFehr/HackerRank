
/*
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

    void levelOrder(Node * root) {
        if(root==NULL)
        return;

        queue<Node *>q1;
        q1.push(root);
        
        while(! q1.empty())
        {
            Node* temp=q1.front();
            cout<<temp->data<<" ";
             
            if(temp->left!=NULL)
            {
                q1.push(temp->left);
            }
            if(temp->right!=NULL)
            q1.push(temp->right);

            q1.pop();
        }

    }

