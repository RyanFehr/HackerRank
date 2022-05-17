function printLinkedList(head) {
  while (head != null) {
    console.log(head.data);
    head = head.next;
  }
}
