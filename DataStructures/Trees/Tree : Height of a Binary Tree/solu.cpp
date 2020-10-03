
/*The tree node has data, left child and right child 
class Node {
    int data;
    Node* left;
    Node* right;
};

*/
    int height(Node* root) {
        // Write your code here.
        if(root == NULL){
              return -1;
        }
        int left = height(root->left);
        int right = height(root->right);
        int max = left > right ? left : right;
        return max+1;
    }

