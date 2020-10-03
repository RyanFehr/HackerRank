

// Complete the mergeLists function below.

/*
 * For your reference:
 *
 * SinglyLinkedListNode {
 *     int data;
 *     SinglyLinkedListNode* next;
 * };
 *
 */
SinglyLinkedListNode* mergeLists(SinglyLinkedListNode* head1, SinglyLinkedListNode* head2) {
SinglyLinkedListNode* temp;

if(head1==NULL&&head2==NULL){
    return NULL;

}

if(head1==NULL) return head2;
if(head2==NULL) return head1;

if(head1->data<head2->data){
    head1->next=mergeLists(head1->next,head2);
    return head1;
}

else{
   head2->next=mergeLists(head2->next,head1);
    return head2;
}

}

