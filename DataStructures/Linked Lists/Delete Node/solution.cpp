
//https://www.hackerrank.com/challenges/delete-a-node-from-a-linked-list/problem
/*
  Delete Node at a given position in a linked list 
  Node is defined as 
  struct Node
  {
     int data;
     struct Node *next;
  }
*/
Node* Delete(Node *head, int position)
{
  // Complete this method
    
    if(position == 0){
        return head->next;
    }
    else{
    head->next = Delete(head->next,position-1);
    return head;
    }
    
}
