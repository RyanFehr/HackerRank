/*
    Problem : https://www.hackerrank.com/challenges/delete-a-node-from-a-linked-list/problem
    C++ 14
    Approach : 
        We simply need to iterate the linked list and then remove an element by adjusting the node pointers
    
    Time Complexity : O(n)
    Space Complexity : O(1)
*/
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
 // This is a "method-only" submission.
  // You only need to complete this method   
}
