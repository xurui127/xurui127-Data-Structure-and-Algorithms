

#include <iostream>
using namespace std;

class Node {
public:

	int data;
	Node* next;
	Node(int _data) :data{ _data }, next{ nullptr } {}

};
class Stack {

	Node* top;
	Node* bottom;
	int length = 0;
public:
	Stack() :top{ nullptr }, bottom{ nullptr }, length{ 0 }{}
	bool IsEmpty() {
		if (length > 0)
		{
			return true;
		}
		else
		{
			return false;
		}
	}
	int Size() {
		Node* temp = top;
		int size = 0;
		while (temp->next != nullptr)
		{
			size++;
			temp = temp->next;
		}
		return size;
	}
	void Push(int data) {
		Node* newNode = new Node(data);
		if (top == nullptr)
		{
			top = newNode;
			length++;
			return;
		}
		length++;
		newNode->next = top;
		top = newNode;
	}
	void Pop() {

		if (top == NULL) {
			cout << "Empty" << endl;
			return;
		}
		Node* temp = top;
		top = top->next;
		free(temp);


	}
	void Display() {
		Node* currentNode = top;
		if (top == NULL)
		{
			return;
		}
		while (currentNode != NULL)
		{
			cout << currentNode->data << endl;
			currentNode = currentNode->next;
		}
	}
};


int main()
{
	Stack myStack;
	myStack.Push(1);
	myStack.Push(2);
	myStack.Push(3);
	myStack.Push(4);
	myStack.Push(4);
	myStack.Display();
	cout << "===================" << endl;
	myStack.Pop();
	myStack.Pop();
	myStack.Display();


}

