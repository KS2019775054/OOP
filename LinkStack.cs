using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Node
    {
        public int data;
        public Node next;

        public Node(int data)
        {
            this.data = data;
            next = null;
        }
    }

    class Stack
    {
        private Node top;

        public Stack()
        {
            top = null;
        }

        public void Push(int data)
        {
            Node newNode = new Node(data);

            if (top == null)
            {
                top = newNode;
            }
            else
            {
                newNode.next = top;
                top = newNode;
            }
        }

        public int Pop()
        {
            if (top == null)
            {
                Console.WriteLine("스택이 비었습니다");
                return -1;
            }
            else
            {
                int data = top.data;
                top = top.next;
                return data;
            }
        }


        public bool IsEmpty()
        {
            return (top == null);
        }
    }
    internal class LinkStack
    {
        static void Main(string[] args)
        {
            Stack myStack = new Stack();

            myStack.Push(11);
            myStack.Push(22);
            myStack.Push(33);
            myStack.Push(44);
            myStack.Push(55);

            Console.WriteLine("스택 Pop 하면서 출력");

            while (!myStack.IsEmpty())
            {
                Console.WriteLine(myStack.Pop());
            }
        }
    }
}
