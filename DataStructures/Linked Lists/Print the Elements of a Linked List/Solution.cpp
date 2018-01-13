/*
	Problem: https://www.hackerrank.com/challenges/print-the-elements-of-a-linked-list
	Language : C++
	Tool Version : Visual Studio Community 2017
	Thoughts :
	1. Let the head node pointer be h.
	2. Start a loop
		2.1 If h is null then quit the loop.
		2.2 If h is not null then print the data portion of node pointed by h.
		2.3 Move h to node pointed by next pointer of node currently pointed by h.
		2.4 Go to step 2.1
	3. End
		
	Time Complexity:  O(n)
	Space Complexity: O(1) //number of dynamically allocated variables remain constant for any length of linked list.

	*/

/*
  Print elements of a linked list on console 
  head pointer input could be NULL as well for empty list
  Node is defined as 
  struct Node
  {
     int data;
     struct Node *next;
  }
*/
void Print(Node *head)
{
	if (head == NULL)
		return;
    
	do
	{
		printf("%d\n", head->data);
		head = head->next;
	} while (head != NULL);
}
