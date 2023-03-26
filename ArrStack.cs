using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class ArrStack
    {
        private int[] stack;
        private int top;

        public ArrStack(int size)
        {
            stack = new int[size];
            top = -1;
        }

        public void Push(int num)
        {
            if (top == stack.Length - 1)
            {
                Console.WriteLine("스택에 공간이 없습니다");
            }
            else
            {
                top++;
                stack[top] = num;
            }
        }

        public int Pop()
        {
            if (top == -1)
            {
                Console.WriteLine("스택에 값이 없습니다");
                return -1;
            }
            else
            {
                int num = stack[top];
                top--;
                return num;
            }
        }



        public bool IsEmpty()
        {
            return (top == -1);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            ArrStack myStack = new ArrStack(5);//스택생성

            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);
            myStack.Push(4);
            myStack.Push(5);
            
            Console.WriteLine("스택 Pop 하며 출력");
            while (!myStack.IsEmpty())
            {
                Console.WriteLine(myStack.Pop());
            }

           
        }
    }
}
