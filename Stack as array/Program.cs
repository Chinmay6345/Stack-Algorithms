using System;

namespace Stack_as_array
{
    public class Stack
    {
        Int32[] arr;
        Int32 capacity;
        Int32 top;

        public Stack(Int32 c)
        {
            top = -1;
            capacity = c;
            arr = new Int32[c];
        }

        public void Push(Int32 x)
        {
            if(top==capacity-1)
            {
                Console.WriteLine("Stack Full");
                return;
            }
            top++;
            arr[top] = x;
        }

        public Int32 Pop()
        {
            if(top==-1)
            {
                Console.WriteLine("Stack Empty");
                return -1;
            }
            Int32 result = arr[top];
            top--;
            return result;
        }

        public Int32 Peek()
        {
            if(top==-1)
            {
                Console.WriteLine("Stack Empty");
                return -1;
            }
            return arr[top];
        }

        public bool IsEmpty()
        {
            return top == -1;
        }

        public Int32 Size()
        {
            return top + 1;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack(5);
            stack.Push(10);
            stack.Push(20);
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Peek());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.ReadLine();
        }
    }
}
