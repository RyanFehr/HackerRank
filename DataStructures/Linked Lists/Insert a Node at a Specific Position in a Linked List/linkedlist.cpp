

// Complete the insertNodeAtPosition function below.

/*
 * For your reference:
 *
 * SinglyLinkedListNode {
 *     int data;
 *     SinglyLinkedListNode* next;
 * };
 *
 */
SinglyLinkedListNode* insertNodeAtPosition(SinglyLinkedListNode* head, int data, int position) {

SinglyLinkedListNode *temp=new SinglyLinkedListNode(data);
SinglyLinkedListNode *nh;
nh=head;
for(int i=0;i<position-1;i++)
{
    nh=nh->next;
}
SinglyLinkedListNode *t;
t=nh->next ;
temp->next=t;
nh->next=temp;

return head;

}

