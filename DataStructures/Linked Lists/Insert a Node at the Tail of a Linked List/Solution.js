function insertNodeAtTail(head, data) {
    const newNode = {
        data: data,
        next: null,
    }
    if(!head){
        // head = new SinglyLinkedList(data, null)
        head = newNode
        return head
    }
    let currentNode = head
    while(currentNode.next){
        currentNode = currentNode.next
    }
    currentNode.next = newNode
    return head
}