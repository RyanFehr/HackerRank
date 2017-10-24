/*
  Compare two linked lists A and B
  Return 1 if they are identical and 0 if they are not.
  Node is defined as
  struct Node
  {
     int data;
     struct Node *next;
  }
*/
int CompareLists(Node *headA, Node* headB)
{
    while(headA != NULL && headB!=NULL)
    {
        if(headA->data != headB->data)
            return 0;
        headA = headA->next;
        headB = headB->next;
    }
    if(headA == NULL && headB == NULL)
        return 1;
    else
        return 0;
  // This is a "method-only" submission.
  // You only need to complete this method
}
