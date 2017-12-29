// Problem: https://www.hackerrank.com/challenges/reverse-a-linked-list
// Java 7
/*
  Reverse a linked list and return pointer to the head
  The input list will have at least one element  
  Node is defined as  
  class Node {
     int data;
     Node next;
  }
*/
    // This is a "method-only" submission. 
    // You only need to complete this method. 
Node Reverse(Node head) {
    Node tail = null;
    while(head != null) {
        Node next = head.next;
        head.next = tail;
        tail = head;
        head = next;
    }
    return tail;
}
