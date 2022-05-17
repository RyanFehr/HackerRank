function deleteNode(llist, position) {
  // Write your code here
  if (position == 0) {
    llist = llist.next;
  } else {
    let temp = llist;
    let count = 1;
    while (temp !== null && count < position) {
      temp = temp.next;
      count++;
    }
    temp.next = temp.next.next;
  }
  return llist;
}
